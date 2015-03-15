/**
 * 功能  操作数据库类
 */
package db;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.provider.ContactsContract.Contacts.Data;

public class DBHelper extends SQLiteOpenHelper {
    private static final String DB_NAME = "coll.db";  
    private static final String TBL_NAME = "CollTbl";  
    private static final String CREATE_TBL = " create table "  
            + " CollTbl(_id integer primary key autoincrement,name text,url text, desc text) ";  
      
    private SQLiteDatabase db;  
    public DBHelper(Context c) {  
        super(c, DB_NAME, null, 2);  
    } 
	
    @Override  
    public void onCreate(SQLiteDatabase db) {  
        this.db = db;  
        db.execSQL(CREATE_TBL);  
    }  
    public void insert(ContentValues values) {
        SQLiteDatabase db = getWritableDatabase();  
        db.insert(TBL_NAME, null, values);  
        db.close();  
    }  
    public Cursor query() {
    	String sql = "select * from " + TBL_NAME + " order by _id desc limit 10";
        SQLiteDatabase db = getWritableDatabase();
        Cursor c = db.rawQuery(sql, null);
//        Cursor c = db.query(TBL_NAME, null, null, null, null, null, null);  
        return c;  
    } 
    public void del(int id) {  
        if (db == null)  
            db = getWritableDatabase();  
        db.delete(TBL_NAME, "_id=?", new String[] { String.valueOf(id) });  
    }  
    public void close() {  
        if (db != null)  
            db.close();  
    }
    public void clearFeedTable() {
    	String sql = "DELETE FROM " + TBL_NAME + "";
    	SQLiteDatabase db = getWritableDatabase();
    	db.execSQL(sql);
    	revertSeq();
    }
    private void revertSeq() {
    	String sql = "update sqlite_sequence set seq=0 where name='" + TBL_NAME + "'";
    	SQLiteDatabase db = getWritableDatabase();
    	db.execSQL(sql);
    }
    
    @Override  
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {  
    } 

}
