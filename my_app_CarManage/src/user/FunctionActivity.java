/**
 * 功能  功能界面
 */
package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.LandingActivity;
import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.Toast;

public class FunctionActivity extends Activity {	
	public static String caridString = "";
	private ImageView imageView_monitoring;	//车辆监控按钮
	private ImageView imageView_choose;	//车辆选择按钮
	private ImageView imageView_affirm;	//确认收货按钮
	private ImageView imageView_contact;	//联系车主按钮
	private ImageView imageView_alarm;	//设置警报按钮
	private ImageView imageView_weather;	//查看天气按钮
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.function_main);        
        
		try {
	        /**
	         * 功能  获取用户绑定车辆
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//参数名
			ArrayList<String> ParValues = new ArrayList<String>();	//参数
			Parameters.add("Phone");
			ParValues.add(LandingActivity.phone);
					
			HttpWebService httpWebService = new HttpWebService(); 
			httpWebService.GetWebServre("selectBound", Parameters, ParValues); 
			Thread functionThread = new Thread(httpWebService);
			functionThread.start();
			
			Thread.sleep(1000);
						
			if (httpWebService.data.equals("")) {
				Toast.makeText(FunctionActivity.this, "还没有选择车辆，请不要进行其他操作！", Toast.LENGTH_LONG).show();				
			}
			
			caridString = httpWebService.data;	//记录车ID							
			
		} catch (InterruptedException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}		
		
        /*
         * 车辆监控按钮点击事件
         */
        imageView_monitoring = (ImageView) findViewById(R.id.imageView_monitoring);        
        imageView_monitoring.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(FunctionActivity.this, MonitoringActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 车辆选择按钮点击事件
         */
        imageView_choose = (ImageView) findViewById(R.id.imageView_choose);        
        imageView_choose.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {		
				Intent intent = new Intent(FunctionActivity.this, ChooseActivity.class);
				startActivity(intent);	
			}
        });
        
        /*
         * 联系车主按钮点击事件
         */
        imageView_contact = (ImageView) findViewById(R.id.imageView_contact);        
        imageView_contact.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(FunctionActivity.this, ContactActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 设置警报按钮点击事件
         */
        imageView_alarm = (ImageView) findViewById(R.id.imageView_alarm);        
        imageView_alarm.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(FunctionActivity.this, AlarmActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 确认收货按钮点击事件
         */
        imageView_affirm = (ImageView) findViewById(R.id.imageView_affirm);        
        imageView_affirm.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(FunctionActivity.this, AffirmActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 天气预报按钮点击事件
         */
        imageView_weather = (ImageView) findViewById(R.id.imageView_weather);        
        imageView_weather.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(FunctionActivity.this, WeatherActivity.class);
				startActivity(intent);
			}
        });
    }
}
