/**
 * ����  ����ԱԤ�辯��ֵ
 */
package admin;

import java.util.ArrayList;
import util.HttpWebService;
import com.example.my_app_carmanage.R;
import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class AdminAlarmActivity extends Activity {
	HttpWebService httpWebService = new HttpWebService(); 
	public ArrayAdapter<String> adapter;	//�����б�������
	public Spinner spinner; //���������б�
	public String TemperatureMax = "";	//��¼�¶�����
	public String TemperatureMin = "";	//��¼�¶�����

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admin_alarm);   
        		
		try {
			
	        /**
	         * ����  ��ȡȫ������
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//������
			ArrayList<String> ParValues = new ArrayList<String>();	//����
			
			httpWebService.GetWebServre("adminCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
			
			String[] ctype = httpWebService.data.split("#");	        
	        
	        adapter=new ArrayAdapter<String>(AdminAlarmActivity.this,android.R.layout.simple_spinner_item,ctype);
	        
	        spinner = (Spinner) findViewById(R.id.spinner_alarm);	//�����б�
	        
	        spinner.setAdapter(adapter);
	        
		} catch (InterruptedException e1) {
			// TODO �Զ����ɵ� catch ��
			e1.printStackTrace();
		}				
        
        Button btn_alarm=(Button)findViewById(R.id.btn_alarm2);	//��ȡȷ����ť
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				try {
					TemperatureMax=((EditText)findViewById(R.id.TemperatureMax2)).getText().toString();	//��ȡ������¶�
					TemperatureMin=((EditText)findViewById(R.id.TemperatureMin2)).getText().toString();	//��ȡ�����ʪ��					
					
					if(!"".equals(TemperatureMax) || !"".equals(TemperatureMin)) {

				        /**
				         * ����  ���þ���ֵ
				         */
						ArrayList<String> Parameters = new ArrayList<String>();	//������
						ArrayList<String> ParValues = new ArrayList<String>();	//����
				        Parameters.add("Carid");
				        ParValues.add(spinner.getSelectedItem().toString());
					    Parameters.add("TemperatureMax");
				        ParValues.add(TemperatureMax);
				        Parameters.add("TemperatureMin");
				        ParValues.add(TemperatureMin);
								
						httpWebService.GetWebServre("updateAlarm", Parameters, ParValues); 
						Thread alarmThread = new Thread(httpWebService);
						alarmThread.start();
						
						Thread.sleep(1000);
						
						System.out.println("����ֵ��" + TemperatureMax + " " + TemperatureMin);
						
					}else {
						Toast.makeText(AdminAlarmActivity.this, "�����뾯��ֵ����������", Toast.LENGTH_LONG).show();
					}	
					Toast.makeText(AdminAlarmActivity.this, "���óɹ�", Toast.LENGTH_LONG).show();
					
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });
    }

}
