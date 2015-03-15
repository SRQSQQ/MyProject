/**
 * 功能  用户确认收货界面
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
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

public class AffirmActivity extends Activity {
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.affirm_main);
        
        Button btn_alarm=(Button)findViewById(R.id.btn_affirm);	//获取确认收货按钮
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {				
		        /**
		         * 功能  确认收货
		         */
				ArrayList<String> Parameters = new ArrayList<String>();	//参数名
				ArrayList<String> ParValues = new ArrayList<String>();	//参数
		        Parameters.add("Phone");
		        ParValues.add(LandingActivity.phone);
						
				HttpWebService httpWebService = new HttpWebService(); 
				httpWebService.GetWebServre("UserAffirm", Parameters, ParValues); 
				Thread affirmThread = new Thread(httpWebService);
				affirmThread.start();
				
				Toast.makeText(AffirmActivity.this, "解除请求已发送给管理员！期待下次再为您服务！", Toast.LENGTH_LONG).show();
			}
        });
        

        Button btn_contact=(Button)findViewById(R.id.btn_contact);	//联系方式     
        btn_contact.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AffirmActivity.this, ContactActivity.class);
				startActivity(intent);
			}
        });
    }    
}
