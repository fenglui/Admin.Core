﻿using FreeSql.DataAnnotations;
using System.ComponentModel;

namespace ZhonTai.Admin.Core.Entities;

/// <summary>
/// 实体软删除
/// </summary>
public class EntityDelete<TKey> : Entity<TKey>, IDelete
{
    /// <summary>
    /// 是否删除
    /// </summary>
    [Description("是否删除")]
    [Column(Position = -40)]
    public bool IsDeleted { get; set; } = false;
}

/// <summary>
/// 实体软删除
/// </summary>
public class EntityDelete : EntityDelete<long>
{
}