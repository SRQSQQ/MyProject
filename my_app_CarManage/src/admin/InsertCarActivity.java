/**
 * 功能  车辆添加界面
 */
package admin;

import java.util.ArrayList;

import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class InsertCarActivity extends Activity {
	HttpWebService httpWebService = new HttpWebService();
	/*
	 * 添加、返回按钮	
	 */
	public Button btn_insertcar;
	public Button btn_returncar;
	/*
	 * 添加车辆信息控件
	 */
	public EditText etxt_carid;
	public EditText etxt_legal;
	public EditText etxt_breakRules;
	public EditText etxt_trafficAccident;
	public EditText etxt_cargoLoss;
	public EditText etxt_overspeed;
	public EditText etxt_drunk;
	public EditText etxt_overload;
	/*
	 * 记录车辆信息变量
	 */
	String carid = "";
	String legal = "";
	String breakRules = "";
	String trafficAccident = "";
	String cargoLoss = "";
	String overspeed = "";
	String drunk = "";
	String overload = "";
    
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.admininsertcar_main);

        /*
         * 获取添加车辆信息控件
         */
        etxt_carid = (EditText) findViewById(R.id.etxt_carid);
        etxt_legal = (EditText) findViewById(R.id.etxt_legal);
        etxt_breakRules = (EditText) findViewById(R.id.etxt_breakRules);
        etxt_trafficAccident = (EditText) findViewById(R.id.etxt_trafficAccident);
        etxt_cargoLoss = (EditText) findViewById(R.id.etxt_cargoLoss);
        etxt_overspeed = (EditText) findViewById(R.id.etxt_overspeed);
        etxt_drunk = (EditText) findViewById(R.id.etxt_drunk);
        etxt_overload = (EditText) findViewById(R.id.etxt_overload);
        
        /*
         * 添加按钮点击事件
         */
        btn_insertcar = (Button) findViewById(R.id.btn_insertcar);
        btn_insertcar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {		        
		        carid = etxt_carid.getText().toString().trim();
		        legal = etxt_legal.getText().toString().trim();
		        breakRules = etxt_breakRules.getText().toString().trim();
		        trafficAccident = etxt_trafficAccident.getText().toString().trim();
		        cargoLoss = etxt_cargoLoss.getText().toString().trim();
		        overspeed = etxt_overspeed.getText().toString().trim();
		        drunk = etxt_drunk.getText().toString().trim();
		        overload = etxt_overload.getText().toString().trim();
				
				try {									
			        /**
			         * 功能  添加车辆
			         */
					ArrayList<String> Parameters = new ArrayList<String>();	//参数名
					ArrayList<String> ParValues = new ArrayList<String>();	//参数
			        Parameters.add("Carid");
			        ParValues.add(carid);
			        Parameters.add("Legal");
			        ParValues.add(legal);
			        Parameters.add("BreakRules");
			        ParValues.add(breakRules);
			        Parameters.add("TrafficAccident");
			        ParValues.add(trafficAccident);
			        Parameters.add("CargoLoss");
			        ParValues.add(cargoLoss);
			        Parameters.add("Overspeed");
			        ParValues.add(overspeed);
			        Parameters.add("Drunk");
			        ParValues.add(drunk);
			        Parameters.add("Overload");
			        ParValues.add(overload);
					
					httpWebService.GetWebServre("adminInsert", Parameters, ParValues); 
					Thread deleteThread = new Thread(httpWebService);
					deleteThread.start();
					
					Thread.sleep(1000);
					
					Toast.makeText(InsertCarActivity.this, "添加成功！", Toast.LENGTH_SHORT).show();
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
        });	
        
        /*
         * 返回按钮点击事件
         */
        btn_returncar = (Button) findViewById(R.id.btn_returncar);
        btn_returncar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				finish();
				Intent intent = new Intent(InsertCarActivity.this, AdminCarActivity.class);
				startActivity(intent);
			}
        });
	}
}
