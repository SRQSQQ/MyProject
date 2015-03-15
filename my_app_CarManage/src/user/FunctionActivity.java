/**
 * ����  ���ܽ���
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
	private ImageView imageView_monitoring;	//������ذ�ť
	private ImageView imageView_choose;	//����ѡ��ť
	private ImageView imageView_affirm;	//ȷ���ջ���ť
	private ImageView imageView_contact;	//��ϵ������ť
	private ImageView imageView_alarm;	//���þ�����ť
	private ImageView imageView_weather;	//�鿴������ť
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.function_main);        
        
		try {
	        /**
	         * ����  ��ȡ�û��󶨳���
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//������
			ArrayList<String> ParValues = new ArrayList<String>();	//����
			Parameters.add("Phone");
			ParValues.add(LandingActivity.phone);
					
			HttpWebService httpWebService = new HttpWebService(); 
			httpWebService.GetWebServre("selectBound", Parameters, ParValues); 
			Thread functionThread = new Thread(httpWebService);
			functionThread.start();
			
			Thread.sleep(1000);
						
			if (httpWebService.data.equals("")) {
				Toast.makeText(FunctionActivity.this, "��û��ѡ�������벻Ҫ��������������", Toast.LENGTH_LONG).show();				
			}
			
			caridString = httpWebService.data;	//��¼��ID							
			
		} catch (InterruptedException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}		
		
        /*
         * ������ذ�ť����¼�
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
         * ����ѡ��ť����¼�
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
         * ��ϵ������ť����¼�
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
         * ���þ�����ť����¼�
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
         * ȷ���ջ���ť����¼�
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
         * ����Ԥ����ť����¼�
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
