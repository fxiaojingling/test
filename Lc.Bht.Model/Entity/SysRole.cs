//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author CHENGE
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace Lc.Bht.Model
{
    ///<summary>
    ///角色定义
    ///</summary>
    [SugarTable("sys_role")]
    public class SysRole
    {
          public SysRole()
          {
          }

           /// <summary>
           /// 描述 : ID 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "ID")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// 描述 : 角色名称 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "角色名称")]           
           public string Name {get;set;}

           /// <summary>
           /// 描述 : 备注 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "备注")]           
           public string Remark {get;set;}

           /// <summary>
           /// 描述 : 创建时间 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建时间")]           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// 描述 : 最后更新时间 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "最后更新时间")]           
           public DateTime UpdateTime {get;set;}

           /// <summary>
           /// 描述 : 创建人编码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建人编码")]           
           public string CreateID {get;set;}

           /// <summary>
           /// 描述 : 创建人 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建人")]           
           public string CreateName {get;set;}

           /// <summary>
           /// 描述 : 更新人编码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新人编码")]           
           public string UpdateID {get;set;}

           /// <summary>
           /// 描述 : 更新人 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新人")]           
           public string UpdateName {get;set;}

           /// <summary>
           /// 描述 : 超级管理员可见 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "超级管理员可见")]           
           public bool Administrator {get;set;}

    }
}