/**
 * 功能  注册界面
 */
package com.example.my_app_carmanage;

import java.util.ArrayList;

import util.HttpWebService;
import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class RegisterActivity extends Activity {
	private EditText register_username;	//用户名
	private EditText register_passwd;	//密码
	private EditText reregister_passwd;	//确认密码
	private Button register_submit;	//注册按钮
	private String Limit = "";	//权限
	public static ArrayAdapter<String> adapter;	//下拉列表适配器
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.register_main);
        
        final Spinner spinner_limit = (Spinner) findViewById(R.id.spinner_limit);	//下拉列表
        
        String[] ctype = {"管理员", "用户"};
        adapter=new ArrayAdapter<String>(RegisterActivity.this,android.R.layout.simple_spinner_item,ctype);
        spinner_limit.setAdapter(adapter);
        
        /**
         * 功能  登陆按钮点击事件
         */
        register_submit=(Button)findViewById(R.id.register_submit);	//获取确定按钮
        register_submit.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				register_username=(EditText)findViewById(R.id.register_username);	
				register_passwd=(EditText)findViewById(R.id.register_passwd);
				reregister_passwd=(EditText)findViewById(R.id.reregister_passwd);
				
				String username=register_username.getText().toString().trim();	//获取用户名
				String password=register_passwd.getText().toString().trim();	//获取密码		
				String reregisterpasswd=reregister_passwd.getText().toString().trim();	//获取密码
				
				try {					
					ArrayList<String> Parameters1 = new ArrayList<String>();
					ArrayList<String> ParValues1 = new ArrayList<String>();
					Parameters1.add("Phone");
					ParValues1.add(username);
				
					//开启新线程
					HttpWebService httpWebService1 = new HttpWebService(); 
					httpWebService1.GetWebServre("UserLanding", Parameters1, ParValues1); 
					Thread loginThread = new Thread(httpWebService1);
					loginThread.start();
					
					//线程休眠
					Thread.sleep(1000);
				
					String[] data = httpWebService1.data.split("#");	//数据解析
				
					if (!data[0].equals("")) {
						Toast.makeText(RegisterActivity.this, "用户名已存在！", Toast.LENGTH_SHORT).show();
					}else if (password.length()<6) {
						Toast.makeText(RegisterActivity.this, "请输入大于6位的密码！", Toast.LENGTH_SHORT).show();
					}else if (!password.equals(reregisterpasswd)) {
						Toast.makeText(RegisterActivity.this, "输入密码不一致！请重新输入！", Toast.LENGTH_SHORT).show();
					}else {
						if (spinner_limit.getSelectedItem().toString().equals("管理员")) {
							Limit = "0";
						} else if (spinner_limit.getSelectedItem().toString().equals("用户")){
							Limit = "1";
						}
						
						ArrayList<String> Parameters2 = new ArrayList<String>();
						ArrayList<String> ParValues2 = new ArrayList<String>();
						Parameters2.add("Phone");
						ParValues2.add(username);
						Parameters2.add("Password");
						ParValues2.add(password);
						Parameters2.add("Limit");
						ParValues2.add(Limit);
					
						//开启新线程
						HttpWebService httpWebService2 = new HttpWebService(); 
						httpWebService2.GetWebServre("UserRegister", Parameters2, ParValues2); 
						Thread registerThread = new Thread(httpWebService2);
						registerThread.start();
					
						Toast.makeText(RegisterActivity.this, "注册成功", Toast.LENGTH_SHORT).show();
					}
				} catch (InterruptedException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
        });
    }
}
