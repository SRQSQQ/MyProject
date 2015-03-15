/**
 * ����  ����Ա���ܽ���
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
	private ImageView imageView_car;	//��������ť
	private ImageView imageView_relieve;	//����󶨰�ť	
	private ImageView imageView_alarm2;	//���þ�����ť
	public static String relieveCar = "";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admin_main);
		
		try {	        
	        /**
	         * ����  ��ȡ����󶨳���
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//������
			ArrayList<String> ParValues = new ArrayList<String>();	//����
			
			httpWebService.GetWebServre("relieveCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
												
			if (!httpWebService.data.equals("")) {
				//��¼���û�
				relieveCar = httpWebService.data.substring(0, 11);
				//��ʾ�����󶨵��û�
				Toast.makeText(AdminActivity.this, httpWebService.data.substring(0, 11) +"�������󶨣�", Toast.LENGTH_LONG).show();
			}
		} catch (InterruptedException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}
        
        /*
         * ��������ť����¼�
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
         * ���þ�����ť����¼�
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
         * ����󶨰�ť����¼�
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
