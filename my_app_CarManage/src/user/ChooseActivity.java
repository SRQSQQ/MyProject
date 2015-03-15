/**
 * ����  �û�������Ϣ��ѯ����
 */
package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.AdapterView.OnItemSelectedListener;

public class ChooseActivity extends Activity {
	public static ArrayAdapter<String> adapter;	//�����б�������
	HttpWebService httpWebService = new HttpWebService();
	static String SeleteCarid = "";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.choose_main); 
        
        final Spinner spinner = (Spinner) findViewById(R.id.spinner1);	//�����б�
        	    
		try {						
	        /**
	         * ����  ��ȡ���г���
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//������
			ArrayList<String> ParValues = new ArrayList<String>();	//����
					 
			httpWebService.GetWebServre("chooseCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
			
			httpWebService.data = "ѡ��#" + httpWebService.data;			
			String[] ctype = httpWebService.data.split("#");		    			
			
			adapter=new ArrayAdapter<String>(ChooseActivity.this,android.R.layout.simple_spinner_item,ctype);
			
			spinner.setAdapter(adapter);
			
			final TextView txtCARID = (TextView) this.findViewById(R.id.txtCARID);	//����ID
			final TextView txtLegal = (TextView) this.findViewById(R.id.txtLegal);	//�Ƿ�Ϸ�
			final TextView txtBreakRules = (TextView) this.findViewById(R.id.txtBreakRules);	//�Ƿ�Υ��
			final TextView txtTrafficAccident = (TextView) this.findViewById(R.id.txtTrafficAccident);//�Ƿ�����ͨ�¹�			
			final TextView txtCargoLoss = (TextView) this.findViewById(R.id.txtCargoLoss);	//�Ƿ��л�����ʧ
			final TextView txtOverspeed = (TextView) this.findViewById(R.id.txtOverspeed);	//���ٴ���
			final TextView txtDrunk = (TextView) this.findViewById(R.id.txtDrunk);	//�Ƽݴ���
			final TextView txtOverload = (TextView) this.findViewById(R.id.txtOverload);	//���ش���
			
			// Ϊѡ���б�����OnItemSelectedListener�¼�����
			spinner.setOnItemSelectedListener(new OnItemSelectedListener() {
				@Override
				public void onItemSelected(AdapterView<?> parent, View arg1,
						int pos, long id) {
					String result = parent.getItemAtPosition(pos).toString(); // ��ȡѡ�����ֵ														
					
			        /**
			         * ����  ��ȡѡ����Ϣ
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//������
					ArrayList<String> ParValues = new ArrayList<String>();	//����
					Parameters.add("Carid");
					ParValues.add(result);
					
					httpWebService.data = "";
					httpWebService.GetWebServre("violationInformation", Parameters, ParValues); 
					Thread thread = new Thread(httpWebService);
					thread.start();				
				}

				@Override
				public void onNothingSelected(AdapterView<?> arg0) {
				}
			});
			
			Button btn_selectCar = (Button) this.findViewById(R.id.btn_selectCar);
			btn_selectCar.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					System.out.println("ѡ����Ϣ��" + httpWebService.data);
					
					//��������ʾѡ����Ϣ
					txtCARID.setText(httpWebService.data.substring(2, 9));
					txtLegal.setText(httpWebService.data.substring(10, 13));
					txtBreakRules.setText(httpWebService.data.substring(14, 15));
					txtTrafficAccident.setText(httpWebService.data.substring(16, 17));			
					txtCargoLoss.setText(httpWebService.data.substring(18, 19));
					txtOverspeed.setText(httpWebService.data.substring(20, 21));
					txtDrunk.setText(httpWebService.data.substring(22, 23));
					txtOverload.setText(httpWebService.data.substring(24, 25));
				}
			});
			
			Button btn_chooseCar = (Button) this.findViewById(R.id.btn_chooseCar);
			btn_chooseCar.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					
					//ѡ��ĳ�
					SeleteCarid = spinner.getSelectedItem().toString();
					//��ת��ȷ��ѡ�����
					Intent intent = new Intent(ChooseActivity.this,ChooseCarActivity.class);
					startActivity(intent);
				}
			});
			
		} catch (InterruptedException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}				
    }
}
