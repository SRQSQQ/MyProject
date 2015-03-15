/**
 * 功能  设置警报界面
 */
package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class AlarmActivity extends Activity {
	public String TemperatureMax = "";
	public String TemperatureMin = "";
	public static String TMax = "30";
	public static String TMin = "0";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.alarm_main);   
        
        Button btn_alarm=(Button)findViewById(R.id.btn_alarm);	//获取确定按钮
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				try {
					TemperatureMax=((EditText)findViewById(R.id.TemperatureMax)).getText().toString();	//获取输入的温度
					TemperatureMin=((EditText)findViewById(R.id.TemperatureMin)).getText().toString();	//获取输入的湿度
					
					TMax = TemperatureMax;
					TMin = TemperatureMin;
					
					if(!"".equals(TemperatureMax) || !"".equals(TemperatureMin)) {

				        /**
				         * 功能  设置警报值
				         */
						ArrayList<String> Parameters = new ArrayList<String>();	//参数名
						ArrayList<String> ParValues = new ArrayList<String>();	//参数
				        Parameters.add("Carid");
				        ParValues.add(FunctionActivity.caridString.substring(0, 7));
					    Parameters.add("TemperatureMax");
				        ParValues.add(TemperatureMax);
				        Parameters.add("TemperatureMin");
				        ParValues.add(TemperatureMin);
								
						HttpWebService httpWebService = new HttpWebService(); 
						httpWebService.GetWebServre("updateAlarm", Parameters, ParValues); 
						Thread alarmThread = new Thread(httpWebService);
						alarmThread.start();
						
						Thread.sleep(1000);
						
						System.out.println("警报值：" + TemperatureMax + " " + TemperatureMin);
						
					}else {
						Toast.makeText(AlarmActivity.this, "请输入警报值补充完整！", Toast.LENGTH_LONG).show();
					}	
					Toast.makeText(AlarmActivity.this, "设置成功", Toast.LENGTH_LONG).show();
					
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });
        
        Button btn_contact=(Button)findViewById(R.id.btn_contact2);	//联系方式     
        btn_contact.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AlarmActivity.this, ContactActivity.class);
				startActivity(intent);
			}
        });
    }
    
}
