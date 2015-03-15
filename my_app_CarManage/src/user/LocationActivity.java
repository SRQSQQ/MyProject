/**
 * ����	��λ����
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
	private ImageView imageViewLocation;	//��λ��ť
	public String CARID = "";	//����ID
	public double LONGITUDE = 0;  //����
	public double LATITUDE = 0;   //γ��
	public String TIME = "";	  //ʱ�� 
	TranformGps tranformGps = new TranformGps(); //GPS��׼��
	
    /**��ͼ���������*/
    private BMapManager mBMapManager = null;

    /**��ʾ��ͼ��View*/
    private MapView mMapView = null;

    /**
     * ���о�����������KEYʱ��Ӧ������һ��Ҫд��my_app_Ӧ������Ҳ����˵"my_app_"�Ǳ���Ҫ�еģ���
     * �ٶȵ�ͼSDK�ṩ�ķ�������ѵģ��ӿ���ʹ�ô������ơ�������������Կ��key)���ſ�ʹ�ø���SDK��
     * */
    public static final String BAIDU_MAP_KEY = "C68A9D4FE29E5CA94B7E5327CD6BBC1323BFF856";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		
	      // ע�⣺���ڵ���setContentViewǰ��ʼ��BMapManager���󣬷���ᱨ��
        mBMapManager = new BMapManager(this.getApplicationContext());
        mBMapManager.init(BAIDU_MAP_KEY, new MKGeneralListener() {

            @Override
            public void onGetNetworkState(int iError) {
                if (iError == MKEvent.ERROR_NETWORK_CONNECT) {
                    Toast.makeText(LocationActivity.this.getApplicationContext(),
                            "���������������", 
                            Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onGetPermissionState(int iError) {
                if (iError == MKEvent.ERROR_PERMISSION_DENIED) {
                    // ��ȨKey����
                    Toast.makeText(LocationActivity.this.getApplicationContext(), 
                            "���� DemoApplication.java�ļ�������ȷ����ȨKey��", 
                            Toast.LENGTH_LONG).show();
                }
            }
        });
		
		setContentView(R.layout.monitoring_location);
		
        mMapView = (MapView) this.findViewById(R.id.bmapsView);
        // �����������õ����ſؼ�
        mMapView.setBuiltInZoomControls(true);

        // ��ȡ��ͼ��������������������ƽ�ƺ�����
        MapController mMapController = mMapView.getController();
       
        // �ø����ľ�γ�ȹ���һ��GeoPoint����λ��΢�� (�� * 1E6)                                       
        // �����찲�ŵľ�γ�ȣ�39.915 * 1E6��116.404 * 1E6
        GeoPoint mGeoPoint = new GeoPoint(
                (int) (39.915 * 1E6), 
                (int) (116.404 * 1E6));      
        
        // ���õ�ͼ�����ĵ�
        mMapController.setCenter(mGeoPoint);
        
        // ���õ�ͼ�����ż��� ���ֵ��ȡֵ��Χ��[3,18]�� 
        mMapController.setZoom(15);

        // �ڵ�ͼ����ʾʵʱ��ͨ��Ϣʾ
        //mMapView.setTraffic(true);

        // ���ǵ�ͼ�������������ʵ�ĵ�����ò���������ǵ�ͼ���������������Ϣ��������˽⵽����λ�ã����εȡ�
        //mMapView.setSatellite(true);
        
        /**
         * ��λ����
         */
        imageViewLocation = (ImageView) findViewById(R.id.location);
        imageViewLocation.setAlpha(100);
        
        imageViewLocation.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {								
				try {
					mMapView.getOverlays().clear();
					
			        /**
			         * �����߳̽��ղ�����
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//������
					ArrayList<String> ParValues = new ArrayList<String>();	//����
					Parameters.add("Carid");
					ParValues.add(FunctionActivity.caridString.substring(0, 7));
							
					
					httpWebService.GetWebServre("selectAllCargoInfor", Parameters, ParValues); 
					Thread locationThread = new Thread(httpWebService);
					locationThread.start();
					
					Thread.sleep(1000);					
					
					String[] data = httpWebService.data.split("#");	//����
					
					/**
					 * ���¶Ⱥ͵�ǰʱ��������ݿ�
					 */
					DBHelper helper = new DBHelper(getApplicationContext());
					ContentValues values = new ContentValues();
		            values.put("name", data[1]);  
		            values.put("url", data[5]);  
		            values.put("desc", data[10]);  
		            helper.insert(values);
					
					System.out.println(data[4] + " " + data[3]);										
					
					//�����յľ��Ȳ�ֳ�������longitude
					LONGITUDE = tranformGps.TranformNum1(data[4]);
					//�����յ�γ�Ȳ�ֳ�������latitude
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
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
		});
	}
	
    /**
     * 
     * Ϊ��ͼ��Ӹ�����
     *
     */
    public class MyOverLayItem extends ItemizedOverlay<OverlayItem> {
    	private List<OverlayItem> overlayItem = new ArrayList<OverlayItem>();
    	
    	//�����ڵ�ͼ�ϱ�ʶ���꣬��һ��ͼƬ��ע 
    	public MyOverLayItem(Drawable drawable) {  
    	    super(drawable);    	    
    	    
    	    String[] data = httpWebService.data.split("#");	//����
    	    
    	    //�����յ��¶Ȳ�ֳ�������CARID
    	    CARID = data[1];
    		//�����յ�ʱ���ֳ�������TIME
    		TIME = data[10];
			//�����յľ��Ȳ�ֳ�������longitude
			LONGITUDE = tranformGps.TranformNum1(data[4]);
			//�����յ�γ�Ȳ�ֳ�������latitude
			LATITUDE = tranformGps.TranformNum2(data[3]);
    		
	        // �����찲�ŵľ�γ�ȣ�39.915 * 1E6��116.404 * 1E6
	        GeoPoint mGeoPoint = new GeoPoint(
	                (int) (LONGITUDE * 1E6),
	                (int) (LATITUDE * 1E6));	        	       	        	        
	        
	        GeoPoint mGeoPoint2 = CoordinateConver.fromWgs84ToBaidu(mGeoPoint);
	        
    	    overlayItem.add(new OverlayItem(mGeoPoint2, "A", "���ţ�" + CARID
    	    		+ "\nʱ�䣺" + TIME
    	    		+ "\n���ȣ�" + mGeoPoint2.getLongitudeE6() + "��"
    	    		+ "\nγ�ȣ�" + mGeoPoint2.getLatitudeE6() + "��"
    	    		+ "\n�ڵ㣺" + 1
    	    		+ "\n �¶ȣ�" + data[16] + "��"
    	    		+ "\n ʪ�ȣ�" + data[17] + "%rh"
    	    		+ "\n ���ٶȣ�" + data[18] + "m/s2"
    	    		+ "\n ��ǣ�" + data[19] + "��"
    	    		+ "\n �ٶȣ�" + data[20] + "m/s"
    	    		+ "\n�ڵ㣺" + 2
    	    		+ "\n �¶ȣ�" + data[5] + "��"
    	    		+ "\n ʪ�ȣ�" + data[6] + "%rh"
    	    		+ "\n ���ٶȣ�" + data[7] + "m/s2"
    	    		+ "\n ��ǣ�" + data[8] + "��"
    	    		+ "\n �ٶȣ�" + data[9] + "m/s")); 	        	        
    	    
    	    //ˢ�µ�ͼ  
    	    populate();
    	}

    	//����ָ����List������ÿһ������  
    	@Override  
    	protected OverlayItem createItem(int arg0) {  
    	    return overlayItem.get(arg0);  
    	}  
    	  
    	
    	@Override  
    	public int size() {  
    	    return overlayItem.size();  
    	}
    	
    	//����ע�ﱻ�����ʱ��  
    	@Override  
    	public boolean onTap(int i) {  
    	    Toast.makeText(LocationActivity.this, overlayItem.get(i).getSnippet(), Toast.LENGTH_LONG).show();  
    	    return true;  
    	}
    }
}
