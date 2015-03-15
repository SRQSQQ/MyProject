/**
 * ����  ע�����
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
	private EditText register_username;	//�û���
	private EditText register_passwd;	//����
	private EditText reregister_passwd;	//ȷ������
	private Button register_submit;	//ע�ᰴť
	private String Limit = "";	//Ȩ��
	public static ArrayAdapter<String> adapter;	//�����б�������
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.register_main);
        
        final Spinner spinner_limit = (Spinner) findViewById(R.id.spinner_limit);	//�����б�
        
        String[] ctype = {"����Ա", "�û�"};
        adapter=new ArrayAdapter<String>(RegisterActivity.this,android.R.layout.simple_spinner_item,ctype);
        spinner_limit.setAdapter(adapter);
        
        /**
         * ����  ��½��ť����¼�
         */
        register_submit=(Button)findViewById(R.id.register_submit);	//��ȡȷ����ť
        register_submit.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				register_username=(EditText)findViewById(R.id.register_username);	
				register_passwd=(EditText)findViewById(R.id.register_passwd);
				reregister_passwd=(EditText)findViewById(R.id.reregister_passwd);
				
				String username=register_username.getText().toString().trim();	//��ȡ�û���
				String password=register_passwd.getText().toString().trim();	//��ȡ����		
				String reregisterpasswd=reregister_passwd.getText().toString().trim();	//��ȡ����
				
				try {					
					ArrayList<String> Parameters1 = new ArrayList<String>();
					ArrayList<String> ParValues1 = new ArrayList<String>();
					Parameters1.add("Phone");
					ParValues1.add(username);
				
					//�������߳�
					HttpWebService httpWebService1 = new HttpWebService(); 
					httpWebService1.GetWebServre("UserLanding", Parameters1, ParValues1); 
					Thread loginThread = new Thread(httpWebService1);
					loginThread.start();
					
					//�߳�����
					Thread.sleep(1000);
				
					String[] data = httpWebService1.data.split("#");	//���ݽ���
				
					if (!data[0].equals("")) {
						Toast.makeText(RegisterActivity.this, "�û����Ѵ��ڣ�", Toast.LENGTH_SHORT).show();
					}else if (password.length()<6) {
						Toast.makeText(RegisterActivity.this, "���������6λ�����룡", Toast.LENGTH_SHORT).show();
					}else if (!password.equals(reregisterpasswd)) {
						Toast.makeText(RegisterActivity.this, "�������벻һ�£����������룡", Toast.LENGTH_SHORT).show();
					}else {
						if (spinner_limit.getSelectedItem().toString().equals("����Ա")) {
							Limit = "0";
						} else if (spinner_limit.getSelectedItem().toString().equals("�û�")){
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
					
						//�������߳�
						HttpWebService httpWebService2 = new HttpWebService(); 
						httpWebService2.GetWebServre("UserRegister", Parameters2, ParValues2); 
						Thread registerThread = new Thread(httpWebService2);
						registerThread.start();
					
						Toast.makeText(RegisterActivity.this, "ע��ɹ�", Toast.LENGTH_SHORT).show();
					}
				} catch (InterruptedException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
        });
    }
}
