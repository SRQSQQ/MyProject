/**
 * 功能  用户车辆信息查询界面
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
	public static ArrayAdapter<String> adapter;	//下拉列表适配器
	HttpWebService httpWebService = new HttpWebService();
	static String SeleteCarid = "";
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.choose_main); 
        
        final Spinner spinner = (Spinner) findViewById(R.id.spinner1);	//下拉列表
        	    
		try {						
	        /**
	         * 功能  获取空闲车辆
	         */
			ArrayList<String> Parameters = new ArrayList<String>();	//参数名
			ArrayList<String> ParValues = new ArrayList<String>();	//参数
					 
			httpWebService.GetWebServre("chooseCar", Parameters, ParValues); 
			Thread chooseThread = new Thread(httpWebService);
			chooseThread.start();
			
			Thread.sleep(1000);
			
			httpWebService.data = "选车#" + httpWebService.data;			
			String[] ctype = httpWebService.data.split("#");		    			
			
			adapter=new ArrayAdapter<String>(ChooseActivity.this,android.R.layout.simple_spinner_item,ctype);
			
			spinner.setAdapter(adapter);
			
			final TextView txtCARID = (TextView) this.findViewById(R.id.txtCARID);	//车辆ID
			final TextView txtLegal = (TextView) this.findViewById(R.id.txtLegal);	//是否合法
			final TextView txtBreakRules = (TextView) this.findViewById(R.id.txtBreakRules);	//是否违章
			final TextView txtTrafficAccident = (TextView) this.findViewById(R.id.txtTrafficAccident);//是否发生交通事故			
			final TextView txtCargoLoss = (TextView) this.findViewById(R.id.txtCargoLoss);	//是否有货物损失
			final TextView txtOverspeed = (TextView) this.findViewById(R.id.txtOverspeed);	//超速次数
			final TextView txtDrunk = (TextView) this.findViewById(R.id.txtDrunk);	//酒驾次数
			final TextView txtOverload = (TextView) this.findViewById(R.id.txtOverload);	//超载次数
			
			// 为选择列表框添加OnItemSelectedListener事件监听
			spinner.setOnItemSelectedListener(new OnItemSelectedListener() {
				@Override
				public void onItemSelected(AdapterView<?> parent, View arg1,
						int pos, long id) {
					String result = parent.getItemAtPosition(pos).toString(); // 获取选择项的值														
					
			        /**
			         * 功能  获取选车信息
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//参数名
					ArrayList<String> ParValues = new ArrayList<String>();	//参数
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
					System.out.println("选车信息：" + httpWebService.data);
					
					//解析并显示选车信息
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
					
					//选择的车
					SeleteCarid = spinner.getSelectedItem().toString();
					//跳转到确认选择界面
					Intent intent = new Intent(ChooseActivity.this,ChooseCarActivity.class);
					startActivity(intent);
				}
			});
			
		} catch (InterruptedException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}				
    }
}
