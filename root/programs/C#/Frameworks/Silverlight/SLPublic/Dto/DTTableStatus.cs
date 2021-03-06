//**********************************************************************************
//* Copyright (C) 2007,2014 Hitachi Solutions,Ltd.
//**********************************************************************************

#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

//**********************************************************************************
//* クラス名        ：DTTableStatus
//* クラス日本語名  ：マーシャリング機能付き汎用DTO（表情報の共有クラス）
//*
//* 作成者          ：生技 西野
//* 更新履歴        ：
//*
//*  日時        更新者            内容
//*  ----------  ----------------  -------------------------------------------------
//*  2010/03/xx  西野  大介        新規作成
//**********************************************************************************

using System;
using System.Collections;

namespace Touryo.Infrastructure.Public.Dto
{
    /// <summary>表情報の共有クラス</summary>
    /// <remarks>外部からは使用できないようにする</remarks>
    [System.Diagnostics.DebuggerStepThrough]
    internal class DTTableStatus
    {
        /// <summary>行数</summary>
        /// <remarks>外部からは使用できないようにする</remarks>
        internal int RowsCount = 0;
    }
}
