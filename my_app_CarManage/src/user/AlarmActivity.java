/**
 * ����  ���þ�������
 */
package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class AlarmActivity extends Activity {
	public String TemperatureMax = "";
	public String TemperatureMin = "";
	public static String TMax = "30";
	public static String TMin = "0";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.alarm_main);   
        
        Button btn_alarm=(Button)findViewById(R.id.btn_alarm);	//��ȡȷ����ť
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				try {
					TemperatureMax=((EditText)findViewById(R.id.TemperatureMax)).getText().toString();	//��ȡ������¶�
					TemperatureMin=((EditText)findViewById(R.id.TemperatureMin)).getText().toString();	//��ȡ�����ʪ��
					
					TMax = TemperatureMax;
					TMin = TemperatureMin;
					
					if(!"".equals(TemperatureMax) || !"".equals(TemperatureMin)) {

				        /**
				         * ����  ���þ���ֵ
				         */
						ArrayList<String> Parameters = new ArrayList<String>();	//������
						ArrayList<String> ParValues = new ArrayList<String>();	//����
				        Parameters.add("Carid");
				        ParValues.add(FunctionActivity.caridString.substring(0, 7));
					    Parameters.add("TemperatureMax");
				        ParValues.add(TemperatureMax);
				        Parameters.add("TemperatureMin");
				        ParValues.add(TemperatureMin);
								
						HttpWebService httpWebService = new HttpWebService(); 
						httpWebService.GetWebServre("updateAlarm", Parameters, ParValues); 
						Thread alarmThread = new Thread(httpWebService);
						alarmThread.start();
						
						Thread.sleep(1000);
						
						System.out.println("����ֵ��" + TemperatureMax + " " + TemperatureMin);
						
					}else {
						Toast.makeText(AlarmActivity.this, "�����뾯��ֵ����������", Toast.LENGTH_LONG).show();
					}	
					Toast.makeText(AlarmActivity.this, "���óɹ�", Toast.LENGTH_LONG).show();
					
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });
        
        Button btn_contact=(Button)findViewById(R.id.btn_contact2);	//��ϵ��ʽ     
        btn_contact.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AlarmActivity.this, ContactActivity.class);
				startActivity(intent);
			}
        });
    }
    
}
