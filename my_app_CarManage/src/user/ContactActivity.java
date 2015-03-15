/**
 * 功能  联系车主界面
 */
package user;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.EditText;
import android.widget.ImageButton;

public class ContactActivity extends Activity {
	private ImageButton bt_1,bt_2;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.contact_main);  
        
		bt_1 = (ImageButton) findViewById(R.id.button);
		bt_2 = (ImageButton) findViewById(R.id.button1);
		
		bt_1.setOnClickListener(new buttonListener_1());
		bt_2.setOnClickListener(new buttonListener_2());
    } 
    
	class	buttonListener_1 implements OnClickListener{

		@Override
		public void onClick(View arg0) {
		//	edittext = (EditText)findViewById(R.id.et);
			//具体调用电话号码，需要从数据库调用电话号码。
			Intent intent = new Intent(Intent.ACTION_CALL,Uri.parse("tel:"+"10086"));
			startActivity(intent);
			
		}				
	}
	class	buttonListener_2 implements OnClickListener{

		@Override
		public void onClick(View arg0) {
//			Uri smsToUri = Uri.parse("smsto://10086");
			Intent mIntent = new Intent( android.content.Intent.ACTION_SENDTO, Uri.parse("smsto:"+"10086") );
			startActivity( mIntent );
			
		}				
	}
}
