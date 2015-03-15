/**
 * ����  �û�����ѡ�����
 */
package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.LandingActivity;
import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class ChooseCarActivity extends Activity {
	public String Phone = "";
	public EditText etxt_phone;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.choose_car);
        
        TextView txt_SeleteCarid = (TextView) findViewById(R.id.txt_SeleteCarid);
        txt_SeleteCarid.setText(ChooseActivity.SeleteCarid);
        
        etxt_phone = (EditText) findViewById(R.id.etxt_phone);        
        
        Button btn_OK = (Button) findViewById(R.id.btn_OK);
        btn_OK.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				
				Phone = etxt_phone.getText().toString();
				if (Phone.equals("")) {
					Toast.makeText(ChooseCarActivity.this, "������ֻ��Ų���", Toast.LENGTH_SHORT).show();
				}else if (!LandingActivity.phone.equals(Phone)) {
					Toast.makeText(ChooseCarActivity.this, "������ֻ������¼�û�����һ�£�", Toast.LENGTH_SHORT).show();
				}
				
		        /**
		         * ���� ѡ��
		         */
				ArrayList<String> Parameters = new ArrayList<String>();	//������
				ArrayList<String> ParValues = new ArrayList<String>();	//����
		        Parameters.add("Carid");
		        ParValues.add(ChooseActivity.SeleteCarid);
		        Parameters.add("Phone");
		        ParValues.add(Phone);
				
		        HttpWebService httpWebService = new HttpWebService();
				httpWebService.GetWebServre("updateBound", Parameters, ParValues); 
				Thread chooseThread = new Thread(httpWebService);
				chooseThread.start();
				
				Toast.makeText(ChooseCarActivity.this, "ѡ���ɹ�", Toast.LENGTH_SHORT).show();
			}
		});
    }
}
