/**
 * 功能  解除绑定界面
 */
package admin;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class RelieveActivity extends Activity {
	HttpWebService httpWebService = new HttpWebService();
	private Button btn_relieve;	//解除绑定按钮
	private TextView txt_relieveUser;	//显示用户
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admin_relieve);
        
        txt_relieveUser = (TextView) findViewById(R.id.txt_relieveUser);
        txt_relieveUser.setText(AdminActivity.relieveCar);
        
        /*
         * 解除绑定按钮点击事件
         */
        btn_relieve = (Button) findViewById(R.id.btn_relieve);
        btn_relieve.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				try {
			        /**
			         * 功能  解除绑定
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//参数名
					ArrayList<String> ParValues = new ArrayList<String>();	//参数
					Parameters.add("Phone");
					ParValues.add(AdminActivity.relieveCar);
					
					httpWebService.GetWebServre("relieveBound", Parameters, ParValues); 
					Thread chooseThread = new Thread(httpWebService);
					chooseThread.start();
					
					Thread.sleep(1000);
					
					Toast.makeText(RelieveActivity.this, "解除绑定成功！", Toast.LENGTH_LONG).show();
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });
    }
}
