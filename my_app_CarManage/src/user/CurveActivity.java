/**
 * 功能	折线显示界面
 */
package user;


import util.ChartView;
import com.example.my_app_carmanage.R;
import db.DBHelper;
import android.database.Cursor;
import android.os.Bundle;

public class CurveActivity extends BaseActivity {
	public String number = "";
	public int count = 0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.monitoring_curve);
		
		try {			
			final DBHelper helpter = new DBHelper(this);
	        Cursor c = helpter.query();
	        String AllData = "";
	        String[] data = {""};
	        count = 0;
	        for(c.moveToFirst();!c.isAfterLast();c.moveToNext()) {
	        	int nameColumnIndex = c.getColumnIndex("url");
	        	data = c.getString(nameColumnIndex).split("\\.");
	        	AllData = AllData + data[0] + "#";
	        	System.out.println("温度1:" + Integer.parseInt(data[0]));
	        }	         
	        System.out.println("温度2:" + AllData);
			ChartView myView = (ChartView) this.findViewById(R.id.myView);
			System.out.println("1");
			myView.SetInfo(new String[] { "0", "1", "2", "3", "4", "5", "6",
					"7", "8", "9", "10"}, // X轴刻度
					new String[] { "0", "5", "10", "15", "20", 
					"25", "30" }, // Y轴刻度
//					new int[] { 15, 23, 10, 36, 45, 40, 12 }, // 数据
					AllData.split("#"),
					"温度曲线");									
		} catch (Exception e) {
			// TODO: handle exception
		}

	}
	
	public void onResume() {
		super.onResume();
		
		try {			
			final DBHelper helpter = new DBHelper(this);
	        Cursor c = helpter.query();
	        String AllData = "";
	        String[] data = {""};
	        count = 0;
	        for(c.moveToFirst();!c.isAfterLast();c.moveToNext()) {
	        	int nameColumnIndex = c.getColumnIndex("url");
	        	data = c.getString(nameColumnIndex).split("\\.");
	        	AllData = AllData + data[0] + "#";
	        	System.out.println("温度1:" + Integer.parseInt(data[0]));
	        }	         
	        System.out.println("温度2:" + AllData);
			ChartView myView = (ChartView) this.findViewById(R.id.myView);
			System.out.println("1");
			myView.SetInfo(new String[] { "0", "1", "2", "3", "4", "5", "6",
					"7", "8", "9", "10"}, // X轴刻度
					new String[] { "0", "5", "10", "15", "20", 
					"25", "30"  }, // Y轴刻度
//					new int[] { 15, 23, 10, 36, 45, 40, 12 }, // 数据
					AllData.split("#"),
					"温度曲线");									
		} catch (Exception e) {
			// TODO: handle exception
		}
	}
}
