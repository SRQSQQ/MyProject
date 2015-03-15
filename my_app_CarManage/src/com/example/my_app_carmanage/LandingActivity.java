/**
 * 功能  登录界面
 */
package com.example.my_app_carmanage;

import java.util.ArrayList;

import user.FunctionActivity;
import util.HttpWebService;
import admin.AdminActivity;
import android.R.string;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class LandingActivity extends Activity {
	private EditText login_username;	//用户名
	private EditText login_password;	//密码
	private Button user_login_button;	//登录按钮
	private Button user_register_button;	//注册按钮
	public static String phone = "";
	private String Limit = "";	//权限
	public static ArrayAdapter<String> adapter;	//下拉列表适配器
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.landing_main);
        
        final Spinner spinner_limit2 = (Spinner) findViewById(R.id.spinner_limit2);	//下拉列表
        
        String[] ctype = {"管理员", "用户"};
        adapter=new ArrayAdapter<String>(LandingActivity.this,android.R.layout.simple_spinner_item,ctype);
        spinner_limit2.setAdapter(adapter);
        
        /**
         * 功能  登陆按钮点击事件
         */
        user_login_button=(Button)findViewById(R.id.user_login_button);	//获取登陆按钮
        user_login_button.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				
				login_username=(EditText)findViewById(R.id.login_username);	
				login_password=(EditText)findViewById(R.id.login_password);
				
				String username=login_username.getText().toString().trim();	//获取用户名
				String password=login_password.getText().toString().trim();	//获取密码
				phone = login_username.getText().toString().trim();
				
				if (username.length()<11) {
					Toast.makeText(LandingActivity.this, "输入的用户名不符", Toast.LENGTH_SHORT).show();
				}else {
					try {
						ArrayList<String> Parameters = new ArrayList<String>();	//参数名
						ArrayList<String> ParValues = new ArrayList<String>();	//参数
						Parameters.add("Phone");
						ParValues.add(username);
						
						//开启新线程访问服务器数据库
						HttpWebService httpWebService = new HttpWebService(); 
						httpWebService.GetWebServre("UserLanding", Parameters, ParValues); 
						Thread loginThread = new Thread(httpWebService);
						loginThread.start();
												
						Thread.sleep(1000);
						
						String[] data = httpWebService.data.split("#");	//解析服务器返回数据
						System.out.println(password + "=" +data[2] + " " + data[4]);
						
						if (spinner_limit2.getSelectedItem().toString().equals("管理员")) {
							Limit = "0";
						} else if (spinner_limit2.getSelectedItem().toString().equals("用户")){
							Limit = "1";
						}
						
						if (password.equals("")) {
							Toast.makeText(LandingActivity.this, "请输入密码！", Toast.LENGTH_SHORT).show();						
						}else if (password.equals(data[2])) {
							if (Limit.equals(data[4])) {
								if (data[4].equals("0")) {
									//登录到管理员功能页面
									Intent intent = new Intent(LandingActivity.this, AdminActivity.class);
									startActivity(intent);
								} else if (data[4].equals("1")){
									//登录到用户功能页面
									Intent intent = new Intent(LandingActivity.this, FunctionActivity.class);
									startActivity(intent);
								}
							} else {
								Toast.makeText(LandingActivity.this, "用户没有此权限！", Toast.LENGTH_SHORT).show();
							}
						}else if (data[2].equals("")) {							
							Toast.makeText(LandingActivity.this, "用户名不存在", Toast.LENGTH_SHORT).show();
						}else {
							Toast.makeText(LandingActivity.this, "密码错误", Toast.LENGTH_SHORT).show();
						}
					} catch (Exception e) {
						// TODO: handle exception
					}					
				}				
			}			
        }); 
        
        /**
         * 功能  注册按钮点击事件
         */
        user_register_button=(Button)findViewById(R.id.user_register_button);	//获取注册按钮
        user_register_button.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				Intent intent = new Intent(LandingActivity.this, RegisterActivity.class);
				startActivity(intent);
			}
			
        });         
    }
}
