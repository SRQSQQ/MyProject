/**
 * 功能  底部菜单栏退出Activity
 */
package user;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;

public class BaseActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
	}
	
	 @Override
		public boolean onKeyDown(int keyCode, KeyEvent event) {
			// TODO Auto-generated method stub

			if (keyCode == KeyEvent.KEYCODE_BACK) {

				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.setMessage("你确定退出吗？")
						.setCancelable(false)
						.setPositiveButton("确定",
								new DialogInterface.OnClickListener() {
									public void onClick(DialogInterface dialog,
											int id) {
										finish();
										Intent intent = new Intent(BaseActivity.this, FunctionActivity.class);
										startActivity(intent);
									}
								})
						.setNegativeButton("返回",
								new DialogInterface.OnClickListener() {
									public void onClick(DialogInterface dialog,
											int id) {
										dialog.cancel();
									}
								});
				AlertDialog alert = builder.create();
				alert.show();
				return true;
			}

			return super.onKeyDown(keyCode, event);
		}
}
