/**
 * ����  �û�ȷ���ջ�����
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
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

public class AffirmActivity extends Activity {
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.affirm_main);
        
        Button btn_alarm=(Button)findViewById(R.id.btn_affirm);	//��ȡȷ���ջ���ť
        btn_alarm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {				
		        /**
		         * ����  ȷ���ջ�
		         */
				ArrayList<String> Parameters = new ArrayList<String>();	//������
				ArrayList<String> ParValues = new ArrayList<String>();	//����
		        Parameters.add("Phone");
		        ParValues.add(LandingActivity.phone);
						
				HttpWebService httpWebService = new HttpWebService(); 
				httpWebService.GetWebServre("UserAffirm", Parameters, ParValues); 
				Thread affirmThread = new Thread(httpWebService);
				affirmThread.start();
				
				Toast.makeText(AffirmActivity.this, "��������ѷ��͸�����Ա���ڴ��´���Ϊ������", Toast.LENGTH_LONG).show();
			}
        });
        

        Button btn_contact=(Button)findViewById(R.id.btn_contact);	//��ϵ��ʽ     
        btn_contact.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent(AffirmActivity.this, ContactActivity.class);
				startActivity(intent);
			}
        });
    }    
}
