/**
 * 功能  车辆监控的底部菜单栏主界面
 */

package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import db.DBHelper;
import android.app.TabActivity;
import android.content.ContentValues;
import android.content.Intent;
import android.os.Bundle;
import android.view.Window;
import android.widget.RadioGroup;
import android.widget.RadioGroup.OnCheckedChangeListener;
import android.widget.TabHost;

public class MonitoringActivity extends TabActivity {
	DiscrepancyActivity discrepancyActivity = new DiscrepancyActivity();
	HttpWebService httpWebService = new HttpWebService();
    private TabHost myTabHost;   
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.requestWindowFeature(Window.FEATURE_NO_TITLE);  
        setContentView(R.layout.monitoring_main);                
		
		try {
			/**
			 * 启动线程获取超额信息
			 */
			Thread notStateThread = new Thread(discrepancyActivity);
			notStateThread.start();
			
			//清空数据
            DBHelper helper = new DBHelper(getApplicationContext());
            helper.clearFeedTable();
			
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

			//1 5 10
			System.out.println(data[1] + " " + data[5]+ " " + data[10]);
			
			
			ContentValues values = new ContentValues();
            values.put("name", data[1]);  
            values.put("url", data[5]);  
            values.put("desc", data[10]);  

            helper.insert(values);
			
		} catch (InterruptedException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}					
		
		String[] data = httpWebService.data.split("#");	//解析
        
        myTabHost=this.getTabHost();//从TabActivity上面获取放置Tab的TabHost
        TabHost.TabSpec spec;  
        Intent intent;  
  
        //定位界面
        intent=new Intent().setClass(this, LocationActivity.class);  
        spec=myTabHost.newTabSpec("定位").setIndicator("定位").setContent(intent);  
        myTabHost.addTab(spec);  
        
        //折线显示界面
        intent=new Intent().setClass(this, CurveActivity.class).addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);  
        spec=myTabHost.newTabSpec("折线显示").setIndicator("折线显示").setContent(intent);  
        myTabHost.addTab(spec);  
        
        //列表显示界面
        intent=new Intent().setClass(this, ListActivity.class).addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);  
        spec=myTabHost.newTabSpec("列表显示").setIndicator("列表显示").setContent(intent);  
        myTabHost.addTab(spec);  
          
        //超额温度界面
        intent=new Intent().setClass(this, DiscrepancyActivity.class);  
        spec=myTabHost.newTabSpec("超额温度").setIndicator("超额温度").setContent(intent);  
        myTabHost.addTab(spec);  
        myTabHost.setCurrentTab(0);
        
        RadioGroup radioGroup=(RadioGroup) this.findViewById(R.id.main_tab_group);  
        radioGroup.setOnCheckedChangeListener(new OnCheckedChangeListener() {  
              
            @Override  
            public void onCheckedChanged(RadioGroup group, int checkedId) {  
                // TODO Auto-generated method stub  
                switch (checkedId) {  
                case R.id.main_tab_addExam://定位
                	myTabHost.setCurrentTabByTag("定位");  
                    break;  
                case R.id.main_tab_myExam://折线显示
                	myTabHost.setCurrentTabByTag("折线显示");  
                    break;  
                case R.id.main_tab_message://列表显示
                	myTabHost.setCurrentTabByTag("列表显示");  
                    break;  
                case R.id.main_tab_settings://超额温度
                	myTabHost.setCurrentTabByTag("超额温度");  
                    break;  
                default:    
                    break;  
                }  
            }  
        });  
    }

}
