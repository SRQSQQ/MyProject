/**
 * ����  ������صĵײ��˵���������
 */

package user;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import db.DBHelper;
import android.app.TabActivity;
import android.content.ContentValues;
import android.content.Intent;
import android.os.Bundle;
import android.view.Window;
import android.widget.RadioGroup;
import android.widget.RadioGroup.OnCheckedChangeListener;
import android.widget.TabHost;

public class MonitoringActivity extends TabActivity {
	DiscrepancyActivity discrepancyActivity = new DiscrepancyActivity();
	HttpWebService httpWebService = new HttpWebService();
    private TabHost myTabHost;   
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.requestWindowFeature(Window.FEATURE_NO_TITLE);  
        setContentView(R.layout.monitoring_main);                
		
		try {
			/**
			 * �����̻߳�ȡ������Ϣ
			 */
			Thread notStateThread = new Thread(discrepancyActivity);
			notStateThread.start();
			
			//�������
            DBHelper helper = new DBHelper(getApplicationContext());
            helper.clearFeedTable();
			
	        /**
	         * �����߳̽��ղ�����
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//������
			ArrayList<String> ParValues = new ArrayList<String>();	//����
			Parameters.add("Carid");
			ParValues.add(FunctionActivity.caridString.substring(0, 7));
					
			
			httpWebService.GetWebServre("selectAllCargoInfor", Parameters, ParValues); 
			Thread locationThread = new Thread(httpWebService);
			locationThread.start();
			
			Thread.sleep(1000);
			
			String[] data = httpWebService.data.split("#");	//����

			//1 5 10
			System.out.println(data[1] + " " + data[5]+ " " + data[10]);
			
			
			ContentValues values = new ContentValues();
            values.put("name", data[1]);  
            values.put("url", data[5]);  
            values.put("desc", data[10]);  

            helper.insert(values);
			
		} catch (InterruptedException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}					
		
		String[] data = httpWebService.data.split("#");	//����
        
        myTabHost=this.getTabHost();//��TabActivity�����ȡ����Tab��TabHost
        TabHost.TabSpec spec;  
        Intent intent;  
  
        //��λ����
        intent=new Intent().setClass(this, LocationActivity.class);  
        spec=myTabHost.newTabSpec("��λ").setIndicator("��λ").setContent(intent);  
        myTabHost.addTab(spec);  
        
        //������ʾ����
        intent=new Intent().setClass(this, CurveActivity.class).addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);  
        spec=myTabHost.newTabSpec("������ʾ").setIndicator("������ʾ").setContent(intent);  
        myTabHost.addTab(spec);  
        
        //�б���ʾ����
        intent=new Intent().setClass(this, ListActivity.class).addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);  
        spec=myTabHost.newTabSpec("�б���ʾ").setIndicator("�б���ʾ").setContent(intent);  
        myTabHost.addTab(spec);  
          
        //�����¶Ƚ���
        intent=new Intent().setClass(this, DiscrepancyActivity.class);  
        spec=myTabHost.newTabSpec("�����¶�").setIndicator("�����¶�").setContent(intent);  
        myTabHost.addTab(spec);  
        myTabHost.setCurrentTab(0);
        
        RadioGroup radioGroup=(RadioGroup) this.findViewById(R.id.main_tab_group);  
        radioGroup.setOnCheckedChangeListener(new OnCheckedChangeListener() {  
              
            @Override  
            public void onCheckedChanged(RadioGroup group, int checkedId) {  
                // TODO Auto-generated method stub  
                switch (checkedId) {  
                case R.id.main_tab_addExam://��λ
                	myTabHost.setCurrentTabByTag("��λ");  
                    break;  
                case R.id.main_tab_myExam://������ʾ
                	myTabHost.setCurrentTabByTag("������ʾ");  
                    break;  
                case R.id.main_tab_message://�б���ʾ
                	myTabHost.setCurrentTabByTag("�б���ʾ");  
                    break;  
                case R.id.main_tab_settings://�����¶�
                	myTabHost.setCurrentTabByTag("�����¶�");  
                    break;  
                default:    
                    break;  
                }  
            }  
        });  
    }

}
