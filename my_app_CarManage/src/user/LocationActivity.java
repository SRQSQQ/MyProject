/**
 * 功能	定位界面
 */
package user;


import java.util.ArrayList;
import java.util.List;

import util.HttpWebService;
import util.TranformGps;

import com.baidu.mapapi.BMapManager;
import com.baidu.mapapi.MKGeneralListener;
import com.baidu.mapapi.map.ItemizedOverlay;
import com.baidu.mapapi.map.MKEvent;
import com.baidu.mapapi.map.MapController;
import com.baidu.mapapi.map.MapView;
import com.baidu.mapapi.map.OverlayItem;
import com.baidu.mapapi.utils.CoordinateConver;
import com.baidu.platform.comapi.basestruct.GeoPoint;
import com.example.my_app_carmanage.R;

import db.DBHelper;
import android.content.ContentValues;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ImageView;
import android.widget.Toast;

public class LocationActivity extends BaseActivity {
	HttpWebService httpWebService = new HttpWebService(); 
	private ImageView imageViewLocation;	//定位按钮
	public String CARID = "";	//汽车ID
	public double LONGITUDE = 0;  //经度
	public double LATITUDE = 0;   //纬度
	public String TIME = "";	  //时间 
	TranformGps tranformGps = new TranformGps(); //GPS标准化
	
    /**地图引擎管理类*/
    private BMapManager mBMapManager = null;

    /**显示地图的View*/
    private MapView mMapView = null;

    /**
     * 经研究发现在申请KEY时：应用名称一定要写成my_app_应用名（也就是说"my_app_"是必须要有的）。
     * 百度地图SDK提供的服务是免费的，接口无使用次数限制。您需先申请密钥（key)，才可使用该套SDK。
     * */
    public static final String BAIDU_MAP_KEY = "C68A9D4FE29E5CA94B7E5327CD6BBC1323BFF856";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		
	      // 注意：请在调用setContentView前初始化BMapManager对象，否则会报错
        mBMapManager = new BMapManager(this.getApplicationContext());
        mBMapManager.init(BAIDU_MAP_KEY, new MKGeneralListener() {

            @Override
            public void onGetNetworkState(int iError) {
                if (iError == MKEvent.ERROR_NETWORK_CONNECT) {
                    Toast.makeText(LocationActivity.this.getApplicationContext(),
                            "您的网络出错啦！", 
                            Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onGetPermissionState(int iError) {
                if (iError == MKEvent.ERROR_PERMISSION_DENIED) {
                    // 授权Key错误：
                    Toast.makeText(LocationActivity.this.getApplicationContext(), 
                            "请在 DemoApplication.java文件输入正确的授权Key！", 
                            Toast.LENGTH_LONG).show();
                }
            }
        });
		
		setContentView(R.layout.monitoring_location);
		
        mMapView = (MapView) this.findViewById(R.id.bmapsView);
        // 设置启用内置的缩放控件
        mMapView.setBuiltInZoomControls(true);

        // 获取地图控制器，可以用它控制平移和缩放
        MapController mMapController = mMapView.getController();
       
        // 用给定的经纬度构造一个GeoPoint，单位是微度 (度 * 1E6)                                       
        // 北京天安门的经纬度：39.915 * 1E6，116.404 * 1E6
        GeoPoint mGeoPoint = new GeoPoint(
                (int) (39.915 * 1E6), 
                (int) (116.404 * 1E6));      
        
        // 设置地图的中心点
        mMapController.setCenter(mGeoPoint);
        
        // 设置地图的缩放级别。 这个值的取值范围是[3,18]。 
        mMapController.setZoom(15);

        // 在地图中显示实时交通信息示
        //mMapView.setTraffic(true);

        // 卫星地图是卫星拍摄的真实的地理面貌，所以卫星地图可用来检测地面的信息，你可以了解到地理位置，地形等。
        //mMapView.setSatellite(true);
        
        /**
         * 定位功能
         */
        imageViewLocation = (ImageView) findViewById(R.id.location);
        imageViewLocation.setAlpha(100);
        
        imageViewLocation.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {								
				try {
					mMapView.getOverlays().clear();
					
			        /**
			         * 启动线程接收并解析
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//参数名
					ArrayList<String> ParValues = new ArrayList<String>();	//参数
					Parameters.add("Carid");
					ParValues.add(FunctionActivity.caridString.substring(0, 7));
							
					
					httpWebService.GetWebServre("selectAllCargoInfor", Parameters, ParValues); 
					Thread locationThread = new Thread(httpWebService);
					locationThread.start();
					
					Thread.sleep(1000);					
					
					String[] data = httpWebService.data.split("#");	//解析
					
					/**
					 * 将温度和当前时间插入数据库
					 */
					DBHelper helper = new DBHelper(getApplicationContext());
					ContentValues values = new ContentValues();
		            values.put("name", data[1]);  
		            values.put("url", data[5]);  
		            values.put("desc", data[10]);  
		            helper.insert(values);
					
					System.out.println(data[4] + " " + data[3]);										
					
					//将接收的经度拆分出来赋给longitude
					LONGITUDE = tranformGps.TranformNum1(data[4]);
					//将接收的纬度拆分出来赋给latitude
					LATITUDE = tranformGps.TranformNum2(data[3]);	
					
					java.lang.System.out.println(LONGITUDE + " " + LATITUDE);
					
			        GeoPoint mGeoPoint = new GeoPoint(
			                (int) (LONGITUDE * 1E6), 
			                (int) (LATITUDE * 1E6)); 								        

			        GeoPoint mGeoPoint2 = CoordinateConver.fromWgs84ToBaidu(mGeoPoint);

			        Drawable drawable = getResources().getDrawable(R.drawable.icon_marka);  
			        mMapView.getOverlays().add(new MyOverLayItem(drawable));
			        
			        MapController mMapController = mMapView.getController();		        
					mMapController.setCenter(mGeoPoint2);								
					
					mMapView.refresh();
				} catch (InterruptedException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
		});
	}
	
    /**
     * 
     * 为地图添加覆盖物
     *
     */
    public class MyOverLayItem extends ItemizedOverlay<OverlayItem> {
    	private List<OverlayItem> overlayItem = new ArrayList<OverlayItem>();
    	
    	//用于在地图上标识坐标，用一个图片标注 
    	public MyOverLayItem(Drawable drawable) {  
    	    super(drawable);    	    
    	    
    	    String[] data = httpWebService.data.split("#");	//解析
    	    
    	    //将接收的温度拆分出来赋给CARID
    	    CARID = data[1];
    		//将接收的时间拆分出来赋给TIME
    		TIME = data[10];
			//将接收的经度拆分出来赋给longitude
			LONGITUDE = tranformGps.TranformNum1(data[4]);
			//将接收的纬度拆分出来赋给latitude
			LATITUDE = tranformGps.TranformNum2(data[3]);
    		
	        // 北京天安门的经纬度：39.915 * 1E6，116.404 * 1E6
	        GeoPoint mGeoPoint = new GeoPoint(
	                (int) (LONGITUDE * 1E6),
	                (int) (LATITUDE * 1E6));	        	       	        	        
	        
	        GeoPoint mGeoPoint2 = CoordinateConver.fromWgs84ToBaidu(mGeoPoint);
	        
    	    overlayItem.add(new OverlayItem(mGeoPoint2, "A", "车号：" + CARID
    	    		+ "\n时间：" + TIME
    	    		+ "\n经度：" + mGeoPoint2.getLongitudeE6() + "°"
    	    		+ "\n纬度：" + mGeoPoint2.getLatitudeE6() + "°"
    	    		+ "\n节点：" + 1
    	    		+ "\n 温度：" + data[16] + "℃"
    	    		+ "\n 湿度：" + data[17] + "%rh"
    	    		+ "\n 加速度：" + data[18] + "m/s2"
    	    		+ "\n 倾角：" + data[19] + "°"
    	    		+ "\n 速度：" + data[20] + "m/s"
    	    		+ "\n节点：" + 2
    	    		+ "\n 温度：" + data[5] + "℃"
    	    		+ "\n 湿度：" + data[6] + "%rh"
    	    		+ "\n 加速度：" + data[7] + "m/s2"
    	    		+ "\n 倾角：" + data[8] + "°"
    	    		+ "\n 速度：" + data[9] + "m/s")); 	        	        
    	    
    	    //刷新地图  
    	    populate();
    	}

    	//返回指定的List集合中每一个坐标  
    	@Override  
    	protected OverlayItem createItem(int arg0) {  
    	    return overlayItem.get(arg0);  
    	}  
    	  
    	
    	@Override  
    	public int size() {  
    	    return overlayItem.size();  
    	}
    	
    	//当标注物被点击的时候  
    	@Override  
    	public boolean onTap(int i) {  
    	    Toast.makeText(LocationActivity.this, overlayItem.get(i).getSnippet(), Toast.LENGTH_LONG).show();  
    	    return true;  
    	}
    }
}
