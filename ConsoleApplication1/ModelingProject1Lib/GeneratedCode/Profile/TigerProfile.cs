﻿  
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Common;

public class TigerProfile : Profile : Animal
{
	public TigerProfile(){
		//映射关系配置
		CreateMap<Tiger,TigerView>();
	}
}

