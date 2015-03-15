/**
 * 功能  管理员预设警报值
 */
package admin;

import java.util.ArrayList;
import util.HttpWebService;
import com.example.my_app_carmanage.R;
import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class AdminAlarmActivity extends Activity {
	HttpWebService httpWebService = new HttpWebService(); 
	public ArrayAdapter<String> adapter;	//下拉列表适配器
	public Spinner spinner; //车辆下拉列表
	public String TemperatureMax = "";	//记录温度上限
	public String TemperatureMin = "";	//记录温度下限

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admin_alarm);   
        		
		try {
			
	        /**
	         * 功能  获取全部车辆
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//参数名
			ArrayList<String> ParValues = new ArrayList<String>();	//参数
			
			httpWebService.GetWebServre("adminCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
			
			String[] ctype = httpWebService.data.split("#");	        
	        
	        adapter=new ArrayAdapter<String>(AdminAlarmActivity.this,android.R.layout.simple_spinner_item,ctype);
	        
	        spinner = (Spinner) findViewById(R.id.spinner_alarm);	//下拉列表
	        
	        spinner.setAdapter(adapter);
	        
		} catch (InterruptedException e1) {
			// TODO 自动生成的 catch 块
			e1.printStackTrace();
		}				
        
        Button btn_alarm=(Button)findViewById(R.id.btn_alarm2);	//获取确定按钮
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				try {
					TemperatureMax=((EditText)findViewById(R.id.TemperatureMax2)).getText().toString();	//获取输入的温度
					TemperatureMin=((EditText)findViewById(R.id.TemperatureMin2)).getText().toString();	//获取输入的湿度					
					
					if(!"".equals(TemperatureMax) || !"".equals(TemperatureMin)) {

				        /**
				         * 功能  设置警报值
				         */
						ArrayList<String> Parameters = new ArrayList<String>();	//参数名
						ArrayList<String> ParValues = new ArrayList<String>();	//参数
				        Parameters.add("Carid");
				        ParValues.add(spinner.getSelectedItem().toString());
					    Parameters.add("TemperatureMax");
				        ParValues.add(TemperatureMax);
				        Parameters.add("TemperatureMin");
				        ParValues.add(TemperatureMin);
								
						httpWebService.GetWebServre("updateAlarm", Parameters, ParValues); 
						Thread alarmThread = new Thread(httpWebService);
						alarmThread.start();
						
						Thread.sleep(1000);
						
						System.out.println("警报值：" + TemperatureMax + " " + TemperatureMin);
						
					}else {
						Toast.makeText(AdminAlarmActivity.this, "请输入警报值补充完整！", Toast.LENGTH_LONG).show();
					}	
					Toast.makeText(AdminAlarmActivity.this, "设置成功", Toast.LENGTH_LONG).show();
					
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });
    }

}
