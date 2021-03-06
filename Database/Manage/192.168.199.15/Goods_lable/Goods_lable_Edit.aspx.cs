using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_Goods_lable_Edit : GetTogether.Web.UI.Page
{
    public DO_Goods_lable.UO_Goods_lable UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_Goods_lable.GetObjectById(id);
        }
        if (UO == null) UO = new DO_Goods_lable.UO_Goods_lable();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_Goods_lable.UO_Goods_lable>(UO, "Goods_lable_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_Goods_lable.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("Goods_lable.aspx");
        }
    }
	public partial class DO_Goods_lable : DOBase<DO_Goods_lable.UO_Goods_lable, DO_Goods_lable.UOList_Goods_lable>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "Goods_lable",
                        @"Data Source=192.168.199.88;Initial Catalog=YSL_Shop_Temp;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
                        new string[] {},
                        DatabaseType.SQLServer);
                }
                public override ConnectionInformation GetDefaultConnectionInformation()
                {
                    return GetConnectionInformation();
                }
		public enum Columns
		{
			/// <summary>
			///,Auto Increment,Remark:标签编号
			/// </summary>
			lableid,
			/// <summary>
			///,Remark:商家编号
			/// </summary>
			merchantid,
			/// <summary>
			///,Remark:标签名称
			/// </summary>
			lablename,
			/// <summary>
			///,Remark:标签颜色
			/// </summary>
			lablecolor,
			/// <summary>
			///,Remark:添加时间
			/// </summary>
			addTime,
		}
		public DO_Goods_lable()
		{
		}
		public partial class UO_Goods_lable : UOBase<UO_Goods_lable,UOList_Goods_lable>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _lableid;
			/// <summary>
			///,Auto Increment,Remark:标签编号
			/// </summary>
			[Mapping("lableid,un-insert,un-update")]
			public System.Int32 lableid
			{
				get
				{
					return _lableid;
				}
				set
				{
					_lableid = value;
				}
			}
			private System.Int32 _merchantid;
			/// <summary>
			///,Remark:商家编号
			/// </summary>
			[Mapping("merchantid")]
			public System.Int32 merchantid
			{
				get
				{
					return _merchantid;
				}
				set
				{
					_merchantid = value;
				}
			}
			private System.String _lablename;
			/// <summary>
			///,Remark:标签名称
			/// </summary>
			[Mapping("lablename")]
			public System.String lablename
			{
				get
				{
					return _lablename;
				}
				set
				{
					_lablename = value;
				}
			}
			private System.String _lablecolor;
			/// <summary>
			///,Remark:标签颜色
			/// </summary>
			[Mapping("lablecolor")]
			public System.String lablecolor
			{
				get
				{
					return _lablecolor;
				}
				set
				{
					_lablecolor = value;
				}
			}
			private System.String _addTime;
			/// <summary>
			///,Remark:添加时间
			/// </summary>
			[Mapping("addTime")]
			public System.String addTime
			{
				get
				{
					return _addTime;
				}
				set
				{
					_addTime = value;
				}
			}
			#endregion
			public UO_Goods_lable()
			{
			}
		}
		public partial class UOList_Goods_lable : GetTogether.ObjectBase.ListBase<UO_Goods_lable>
		{
			public UOList_Goods_lable()
			{
			}
		}
	}


	public partial class BO_Goods_lable
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 lableid)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Goods_lable.Columns.lableid, lableid);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_Goods_lable.Columns column,Dictionary<DO_Goods_lable.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_Goods_lable.UO_Goods_lable parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Goods_lable.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.lableid != 0 || (extTokens != null && extTokens.ContainsKey(DO_Goods_lable.Columns.lableid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Goods_lable.Columns.lableid,extTokens), DO_Goods_lable.Columns.lableid,parameterObj.lableid);
			}
			if (parameterObj.merchantid != 0 || (extTokens != null && extTokens.ContainsKey(DO_Goods_lable.Columns.merchantid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Goods_lable.Columns.merchantid,extTokens), DO_Goods_lable.Columns.merchantid,parameterObj.merchantid);
			}
			if (!string.IsNullOrEmpty(parameterObj.lablename))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Goods_lable.Columns.lablename,extTokens), DO_Goods_lable.Columns.lablename,parameterObj.lablename);
			}
			if (!string.IsNullOrEmpty(parameterObj.lablecolor))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Goods_lable.Columns.lablecolor,extTokens), DO_Goods_lable.Columns.lablecolor,parameterObj.lablecolor);
			}
			if (!string.IsNullOrEmpty(parameterObj.addTime))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Goods_lable.Columns.addTime,extTokens), DO_Goods_lable.Columns.addTime,parameterObj.addTime);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_Goods_lable.UOList_Goods_lable GetAllList()
		{
			DO_Goods_lable da = new DO_Goods_lable();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_Goods_lable da = new DO_Goods_lable();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Goods_lable.UO_Goods_lable parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Goods_lable.UO_Goods_lable parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Goods_lable.Columns, TokenTypes> extTokens)
		{
			DO_Goods_lable da = new DO_Goods_lable();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Goods_lable.UOList_Goods_lable GetList(DO_Goods_lable.UO_Goods_lable parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Goods_lable.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Goods_lable.UOList_Goods_lable GetList(DO_Goods_lable.UO_Goods_lable parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_Goods_lable.UO_Goods_lable GetObjectById(System.Int32 lableid)
		{
			DO_Goods_lable da = new DO_Goods_lable();
			DO_Goods_lable.UOList_Goods_lable l = da.GetList(GetConditionsById(lableid));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion
	}

}