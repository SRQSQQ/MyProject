/**
 * 根据日期时间查询数据库中的对应经络
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
        Cursor cur = database.rawQuery("select 灵龟八法,子午流注 from " + date + " where 时辰 = '" + time + "'", null);         
        if (cur != null) {	    
        	if (cur.moveToFirst()) {
        		String StrJL = cur.getString(cur.getColumnIndex("灵龟八法")) + "#" + cur.getString(cur.getColumnIndex("子午流注"));
        		Log.d("经络", StrJL);
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
