/*
 * �Ի���demo����
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
	private Button btn_AlertDialogButton;	//AlertDialog��ť������Ӧ�¼�
	private Button btn_AlertDialogItems;	//AlertDialog�б������Ӧ�¼�
	private Button btn_AlertDialogSingleChoiceItems;	//AlertDialog��ѡ�б������Ӧ�¼�
	private Button btn_AlertDialogMultiChoiceItems;	//AlertDialog��ѡ�б������Ӧ�¼�
	int index = 0;	//����AlertDialog��ѡ�б������Ӧ�¼��м�¼����
	ListView listView; //����AlertDialog��ѡ�б������Ӧ�¼��л�ȡ�б�
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO �Զ����ɵķ������
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
		// TODO �Զ����ɵķ������
		
		switch (v.getId()) {
		//AlertDialog��ť������Ӧ�¼�
		case R.id.btn_AlertDialogButton:
			AlertDialogButton();
			break;
		//AlertDialog�б������Ӧ�¼�
		case R.id.btn_AlertDialogItems:
			AlertDialogItems();
			break;
		//AlertDialog��ѡ�б������Ӧ�¼�
		case R.id.btn_AlertDialogSingleChoiceItems:
			AlertDialogSingleChoiceItems();
			break;
		//AlertDialog��ѡ�б������Ӧ�¼�
		case R.id.btn_AlertDialogMultiChoiceItems:
			AlertDialogMultiChoiceItems();
			break;

		default:
			break;
		}
		
	}
	
	/*
	 * AlertDialog��ť������Ӧ�¼�
	 */
	public void AlertDialogButton() {
		new AlertDialog.Builder(this).setTitle("AlertDialog��ť������Ӧ�¼�").setPositiveButton("����", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO �Զ����ɵķ������
				Toast.makeText(DialogDemo.this, "����զ�Σ�", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog�б������Ӧ�¼�
	 */
	public void AlertDialogItems() {
		final String[] fruit = new String[] {"ƻ��", "����", "�㽶"};
		new AlertDialog.Builder(this).setTitle("AlertDialog�б������Ӧ�¼�").setItems(fruit, new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO �Զ����ɵķ������
				Toast.makeText(DialogDemo.this, "���" + fruit[which] + "�� ������", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog��ѡ�б������Ӧ�¼�
	 */
	public void AlertDialogSingleChoiceItems() {
		final String[] fruit = new String[] {"ƻ��", "����", "�㽶"}; 
		new AlertDialog.Builder(this).setTitle("AlertDialog��ѡ�б������Ӧ�¼�").setSingleChoiceItems(fruit, -1, new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO �Զ����ɵķ������		
				index = which;
			}
		}).setPositiveButton("ѡ��", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO �Զ����ɵķ������
				Toast.makeText(DialogDemo.this, "���" + fruit[index] + "�� ������", Toast.LENGTH_LONG).show();
			}
		}).show();
	}
	
	/*
	 * AlertDialog��ѡ�б������Ӧ�¼�
	 */
	public void AlertDialogMultiChoiceItems() {
		final String[] fruit = new String[] {"ƻ��", "����", "�㽶"}; 
		AlertDialog alertDialog = new AlertDialog.Builder(this).setTitle("AlertDialog��ѡ�б������Ӧ�¼�").setMultiChoiceItems(fruit, null, new DialogInterface.OnMultiChoiceClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which, boolean isChecked) {
				// TODO �Զ����ɵķ������				
			}
		}).setPositiveButton("ѡ��", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				// TODO �Զ����ɵķ������
				String str = "�����:";
				for (int i = 0; i < fruit.length; i++) {
					if (listView.getCheckedItemPositions().get(i)) {
						str = str + "  " + listView.getAdapter().getItem(i);
					}
				}
				if (listView.getCheckedItemPositions().size() > 0) {
					Toast.makeText(DialogDemo.this, str + "! ������", Toast.LENGTH_LONG).show();
				}
				else {
					Toast.makeText(DialogDemo.this, "ʲô����Ҫ����ŭ�ˣ�", Toast.LENGTH_LONG).show();
				}
			}
		}).setNegativeButton("ȡ��", null).create();
		listView = alertDialog.getListView();
		alertDialog.show();
	}

}
