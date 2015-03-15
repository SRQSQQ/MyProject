/*
 * 对话框demo界面
 */
package com.example.androiddemo;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.text.StaticLayout;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

public class DialogDemo extends Activity implements OnClickListener{
	private Button btn_AlertDialogButton;	//AlertDialog按钮单击响应事件
	private Button btn_AlertDialogItems;	//AlertDialog列表项单击响应事件
	private Button btn_AlertDialogSingleChoiceItems;	//AlertDialog单选列表项单击响应事件
	private Button btn_AlertDialogMultiChoiceItems;	//AlertDialog多选列表项单击响应事件
	int index = 0;	//用于AlertDialog单选列表项单击响应事件中记录索引
	ListView listView; //用于AlertDialog多选列表项单击响应事件中获取列表
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		setContentView(R.layout.demo_dialog);
		
		btn_AlertDialogButton = (Button) findViewById(R.id.btn_AlertDialogButton);
		btn_AlertDialogButton.setOnClickListener(this);
		
		btn_AlertDialogItems = (Button) findViewById(R.id.btn_AlertDialogItems);
		btn_AlertDialogItems.setOnClickListener(this);
		
		btn_AlertDialogSingleChoiceItems = (Button) findViewById(R.id.btn_AlertDialogSingleChoiceItems);
		btn_AlertDialogSingleChoiceItems.setOnClickListener(this);
		
		btn_AlertDialogMultiChoiceItems = (Button) findViewById(R.id.btn_AlertDialogMultiChoiceItems);
		btn_AlertDialogMultiChoiceItems.setOnClickListener(this);
	}

	@Override
	public void onClick(View v) {
		// TODO 自动生成的方法存根
		
		switch (v.getId()) {
		//AlertDialog按钮单击响应事件
		case R.id.btn_AlertDialogButton:
			AlertDialogButton();
			break;
		//AlertDialog列表项单击响应事件
		case R.id.btn_AlertDialogItems:
			AlertDialogItems();
			break;
		//AlertDialog单选列表项单击响应事件
		case R.id.btn_AlertDialogSingleChoiceItems:
			AlertDialogSingleChoiceItems();
			break;
		//AlertDialog多选列表项单击响应事件
		case R.id.btn_AlertDialogMultiChoiceItems:
			AlertDialogMultiChoiceItems();
			break;

		default:
			break;
		}
		
	}
	
	/*
	 * AlertDialog按钮单击响应事件
	 */
	public void AlertDialogButton() {
		new AlertDialog.Builder(this).setTitle("AlertDialog按钮单击响应事件").setPositiveButton("点我", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO 自动生成的方法存根
				Toast.makeText(DialogDemo.this, "点你咋滴！", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog列表项单击响应事件
	 */
	public void AlertDialogItems() {
		final String[] fruit = new String[] {"苹果", "橘子", "香蕉"};
		new AlertDialog.Builder(this).setTitle("AlertDialog列表项单击响应事件").setItems(fruit, new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO 自动生成的方法存根
				Toast.makeText(DialogDemo.this, "想吃" + fruit[which] + "！ 不给！", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog单选列表项单击响应事件
	 */
	public void AlertDialogSingleChoiceItems() {
		final String[] fruit = new String[] {"苹果", "橘子", "香蕉"}; 
		new AlertDialog.Builder(this).setTitle("AlertDialog单选列表项单击响应事件").setSingleChoiceItems(fruit, -1, new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO 自动生成的方法存根		
				index = which;
			}
		}).setPositiveButton("选择", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO 自动生成的方法存根
				Toast.makeText(DialogDemo.this, "想吃" + fruit[index] + "！ 不给！", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog多选列表项单击响应事件
	 */
	public void AlertDialogMultiChoiceItems() {
		final String[] fruit = new String[] {"苹果", "橘子", "香蕉"}; 
		AlertDialog alertDialog = new AlertDialog.Builder(this).setTitle("AlertDialog多选列表项单击响应事件").setMultiChoiceItems(fruit, null, new DialogInterface.OnMultiChoiceClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which, boolean isChecked) {
				// TODO 自动生成的方法存根				
			}
		}).setPositiveButton("选择", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO 自动生成的方法存根
				String str = "你想吃:";
				for (int i = 0; i < fruit.length; i++) {
					if (listView.getCheckedItemPositions().get(i)) {
						str = str + "  " + listView.getAdapter().getItem(i);
					}
				}
				if (listView.getCheckedItemPositions().size() > 0) {
					Toast.makeText(DialogDemo.this, str + "! 不给！", Toast.LENGTH_LONG).show();
				}
				else {
					Toast.makeText(DialogDemo.this, "什么都不要！我怒了！", Toast.LENGTH_LONG).show();
				}
			}
		}).setNegativeButton("取消", null).create();
		listView = alertDialog.getListView();
		alertDialog.show();
	}

}
