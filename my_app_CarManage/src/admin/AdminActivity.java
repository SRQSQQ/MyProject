/**
 * 功能  管理员功能界面
 */
package admin;

import java.util.ArrayList;

import user.AlarmActivity;
import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ImageView;
import android.widget.Toast;

public class AdminActivity extends Activity {
	HttpWebService httpWebService = new HttpWebService();
	private ImageView imageView_car;	//车辆管理按钮
	private ImageView imageView_relieve;	//解除绑定按钮	
	private ImageView imageView_alarm2;	//设置警报按钮
	public static String relieveCar = "";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admin_main);
		
		try {	        
	        /**
	         * 功能  获取解除绑定车辆
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//参数名
			ArrayList<String> ParValues = new ArrayList<String>();	//参数
			
			httpWebService.GetWebServre("relieveCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
												
			if (!httpWebService.data.equals("")) {
				//记录绑定用户
				relieveCar = httpWebService.data.substring(0, 11);
				//显示需解除绑定的用户
				Toast.makeText(AdminActivity.this, httpWebService.data.substring(0, 11) +"请求解除绑定！", Toast.LENGTH_LONG).show();
			}
		} catch (InterruptedException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
        
        /*
         * 车辆管理按钮点击事件
         */
        imageView_car = (ImageView) findViewById(R.id.imageView_car);        
        imageView_car.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AdminActivity.this, AdminCarActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 设置警报按钮点击事件
         */
        imageView_alarm2 = (ImageView) findViewById(R.id.imageView_alarm2);        
        imageView_alarm2.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AdminActivity.this, AdminAlarmActivity.class);
				startActivity(intent);
			}
        });
        
        /*
         * 解除绑定按钮点击事件
         */
        imageView_relieve = (ImageView) findViewById(R.id.imageView_relieve);        
        imageView_relieve.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AdminActivity.this, RelieveActivity.class);
				startActivity(intent);
			}
        });
    }

}
