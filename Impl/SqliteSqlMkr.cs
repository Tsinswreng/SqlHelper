namespace Tsinswreng.SqlHelper;

public class SqliteSqlMkr
	:ISqlMkr
{
	protected static SqliteSqlMkr? _Inst = null;
	public static SqliteSqlMkr Inst => _Inst??= new SqliteSqlMkr();

	public str Quote(str Name){
		return "\"" + Name + "\"";
	}

	public str Param(str Name){
		return "@" + Name;
	}


}
