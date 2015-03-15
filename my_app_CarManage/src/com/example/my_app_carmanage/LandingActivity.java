/**
 * ����  ��¼����
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
	private EditText login_username;	//�û���
	private EditText login_password;	//����
	private Button user_login_button;	//��¼��ť
	private Button user_register_button;	//ע�ᰴť
	public static String phone = "";
	private String Limit = "";	//Ȩ��
	public static ArrayAdapter<String> adapter;	//�����б�������
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.landing_main);
        
        final Spinner spinner_limit2 = (Spinner) findViewById(R.id.spinner_limit2);	//�����б�
        
        String[] ctype = {"����Ա", "�û�"};
        adapter=new ArrayAdapter<String>(LandingActivity.this,android.R.layout.simple_spinner_item,ctype);
        spinner_limit2.setAdapter(adapter);
        
        /**
         * ����  ��½��ť����¼�
         */
        user_login_button=(Button)findViewById(R.id.user_login_button);	//��ȡ��½��ť
        user_login_button.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				
				login_username=(EditText)findViewById(R.id.login_username);	
				login_password=(EditText)findViewById(R.id.login_password);
				
				String username=login_username.getText().toString().trim();	//��ȡ�û���
				String password=login_password.getText().toString().trim();	//��ȡ����
				phone = login_username.getText().toString().trim();
				
				if (username.length()<11) {
					Toast.makeText(LandingActivity.this, "������û�������", Toast.LENGTH_SHORT).show();
				}else {
					try {
						ArrayList<String> Parameters = new ArrayList<String>();	//������
						ArrayList<String> ParValues = new ArrayList<String>();	//����
						Parameters.add("Phone");
						ParValues.add(username);
						
						//�������̷߳��ʷ��������ݿ�
						HttpWebService httpWebService = new HttpWebService(); 
						httpWebService.GetWebServre("UserLanding", Parameters, ParValues); 
						Thread loginThread = new Thread(httpWebService);
						loginThread.start();
												
						Thread.sleep(1000);
						
						String[] data = httpWebService.data.split("#");	//������������������
						System.out.println(password + "=" +data[2] + " " + data[4]);
						
						if (spinner_limit2.getSelectedItem().toString().equals("����Ա")) {
							Limit = "0";
						} else if (spinner_limit2.getSelectedItem().toString().equals("�û�")){
							Limit = "1";
						}
						
						if (password.equals("")) {
							Toast.makeText(LandingActivity.this, "���������룡", Toast.LENGTH_SHORT).show();						
						}else if (password.equals(data[2])) {
							if (Limit.equals(data[4])) {
								if (data[4].equals("0")) {
									//��¼������Ա����ҳ��
									Intent intent = new Intent(LandingActivity.this, AdminActivity.class);
									startActivity(intent);
								} else if (data[4].equals("1")){
									//��¼���û�����ҳ��
									Intent intent = new Intent(LandingActivity.this, FunctionActivity.class);
									startActivity(intent);
								}
							} else {
								Toast.makeText(LandingActivity.this, "�û�û�д�Ȩ�ޣ�", Toast.LENGTH_SHORT).show();
							}
						}else if (data[2].equals("")) {							
							Toast.makeText(LandingActivity.this, "�û���������", Toast.LENGTH_SHORT).show();
						}else {
							Toast.makeText(LandingActivity.this, "�������", Toast.LENGTH_SHORT).show();
						}
					} catch (Exception e) {
						// TODO: handle exception
					}					
				}				
			}			
        }); 
        
        /**
         * ����  ע�ᰴť����¼�
         */
        user_register_button=(Button)findViewById(R.id.user_register_button);	//��ȡע�ᰴť
        user_register_button.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				Intent intent = new Intent(LandingActivity.this, RegisterActivity.class);
				startActivity(intent);
			}
			
        });         
    }
}
