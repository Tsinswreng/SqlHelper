namespace Tsinswreng.SqlHelper.Cmd;


public interface ISqlCmdMkr{

	public Task<ISqlCmd> Prepare(
		IBaseDbFnCtx? DbFnCtx
		,str Sql
		,CancellationToken ct
	);

}
