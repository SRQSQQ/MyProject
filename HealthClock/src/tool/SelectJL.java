/**
 * ��������ʱ���ѯ���ݿ��еĶ�Ӧ����
 */
package tool;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

public class SelectJL {
	public String StrJL = "";
	private SQLiteDatabase database;

	public String getJL(String date, String time) {		
		database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);			
        Cursor cur = database.rawQuery("select ���˷�,������ע from " + date + " where ʱ�� = '" + time + "'", null);         
        if (cur != null) {	    
        	if (cur.moveToFirst()) {
        		String StrJL = cur.getString(cur.getColumnIndex("���˷�")) + "#" + cur.getString(cur.getColumnIndex("������ע"));
        		Log.d("����", StrJL);
        		database.close();
        		return StrJL;
        	}else {
        		database.close();
            	return null;
            }	        		        	        	            
        } else {
        	database.close();
        	return null;
        }
	}
}
