namespace Tsinswreng.CsSqlHelper.PostgreSql;

public class PostgreSqlSqlMkr
	:ISqlMkr
{
	protected static PostgreSqlSqlMkr? _Inst = null;
	public static PostgreSqlSqlMkr Inst => _Inst??= new PostgreSqlSqlMkr();
	public ISqlTypeMapper SqlTypeMapper{get;set;} = PostgreSqlTypeMapper.Inst;

	public str Quote(str Name){
		return "\"" + Name + "\"";
	}

	public str Param(str Name){
		return "@" + Name;
	}

	public str LimitOffset(str Limit, str Offset){
		return $"LIMIT {Param(Limit)} OFFSET {Param(Offset)}";
	}


}
