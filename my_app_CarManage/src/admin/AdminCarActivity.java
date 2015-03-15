/**
 * ����  �����������
 */
package admin;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;

public class AdminCarActivity extends Activity {
	public ListView listView_car;
	public Button btn_delete;
	public ArrayAdapter<String> adapter;	//�����б�������
	HttpWebService httpWebService = new HttpWebService();
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admincar_main);
        		
        listView_car = (ListView) findViewById(R.id.listView_car);
        
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
	        
	        adapter=new ArrayAdapter<String>(AdminCarActivity.this,android.R.layout.simple_spinner_item,ctype);
	        
	        listView_car.setAdapter(adapter);
	        
	        btn_delete = (Button) findViewById(R.id.btn_delete);
	        btn_delete.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					finish();
					Intent intent = new Intent(AdminCarActivity.this, InsertCarActivity.class);
					startActivity(intent);
				}
	        });
	        
		} catch (InterruptedException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}
		
    }
}
