/**
 * 功能	列表显示界面
 */
package user;


import com.example.my_app_carmanage.R;

import db.DBHelper;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;

public class ListActivity extends BaseActivity {
	private int time = 0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.monitoring_list);
		
		try {
			final DBHelper helpter = new DBHelper(this);
			
	        Cursor c = helpter.query();  
	        String[] from = { "_id", "name", "url", "desc" };  
	        int[] to = { R.id.txt_id, R.id.txt_Carid, R.id.txt_Temperature, R.id.txt_Time };  
	        SimpleCursorAdapter adapter = new SimpleCursorAdapter(this,  
	                R.layout.monitoring_list, c, from, to);  
	        ListView listView = (ListView) findViewById(R.id.listView1);  
	        listView.setAdapter(adapter); 
	        
	        final AlertDialog.Builder builder = new AlertDialog.Builder(this);
	        listView.setOnItemClickListener(new OnItemClickListener() {  
				@Override
				public void onItemClick(AdapterView<?> parent, View view,
						int position, long id) {  
	                final long temp = id;  
	                builder.setMessage("真的要删除该记录吗？").setPositiveButton("是",  
	                        new DialogInterface.OnClickListener() {  
	                            public void onClick(DialogInterface dialog,  
	                                    int which) {  
	                                helpter.del((int)temp);  
	                                Cursor c = helpter.query();  
	                                String[] from = { "_id", "name", "url", "desc" };  
	                                int[] to = { R.id.txt_id, R.id.txt_Carid, R.id.txt_Temperature, R.id.txt_Time };  
	                                SimpleCursorAdapter adapter = new SimpleCursorAdapter(getApplicationContext(),  
	                                        R.layout.monitoring_list, c, from, to);  
	                                ListView listView =  (ListView) findViewById(R.id.listView1);   
	                                listView.setAdapter(adapter);  
	                            }  
	                        }).setNegativeButton("否",  
	                        new DialogInterface.OnClickListener() {  
	                            public void onClick(DialogInterface dialog,  
	                                    int which) {  
	                                  
	                            }  
	                        });  
	                AlertDialog ad = builder.create();  
	                ad.show();              				
				}  
	        });  
	        helpter.close();	       	        
		} catch (Exception e) {
			// TODO: handle exception
		}
	}
	
	public void onResume() {
		super.onResume();
	
		try {
			final DBHelper helpter = new DBHelper(this);
			
	        Cursor c = helpter.query();  
	        String[] from = { "_id", "name", "url", "desc" };  
	        int[] to = { R.id.txt_id, R.id.txt_Carid, R.id.txt_Temperature, R.id.txt_Time };  
	        SimpleCursorAdapter adapter = new SimpleCursorAdapter(this,  
	                R.layout.monitoring_list, c, from, to);  
	        ListView listView = (ListView) findViewById(R.id.listView1);  
	        listView.setAdapter(adapter); 
	        
	        final AlertDialog.Builder builder = new AlertDialog.Builder(this);
	        listView.setOnItemClickListener(new OnItemClickListener() {  
				@Override
				public void onItemClick(AdapterView<?> parent, View view,
						int position, long id) {  
	                final long temp = id;  
	                builder.setMessage("真的要删除该记录吗？").setPositiveButton("是",  
	                        new DialogInterface.OnClickListener() {  
	                            public void onClick(DialogInterface dialog,  
	                                    int which) {  
	                                helpter.del((int)temp);  
	                                Cursor c = helpter.query();  
	                                String[] from = { "_id", "name", "url", "desc" };  
	                                int[] to = { R.id.txt_id, R.id.txt_Carid, R.id.txt_Temperature, R.id.txt_Time };  
	                                SimpleCursorAdapter adapter = new SimpleCursorAdapter(getApplicationContext(),  
	                                        R.layout.monitoring_list, c, from, to);  
	                                ListView listView =  (ListView) findViewById(R.id.listView1);   
	                                listView.setAdapter(adapter);  
	                            }  
	                        }).setNegativeButton("否",  
	                        new DialogInterface.OnClickListener() {  
	                            public void onClick(DialogInterface dialog,  
	                                    int which) {  
	                                  
	                            }  
	                        });  
	                AlertDialog ad = builder.create();  
	                ad.show();              				
				}  
	        });  
	        helpter.close();	       	        
		} catch (Exception e) {
			// TODO: handle exception
		}
	}
}
