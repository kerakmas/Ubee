﻿using Ubee.Domain.Entities;

namespace Ubee.Data.IRepositories;

public interface IInfoRepository
{
    ValueTask<Info> InsertInfoAsync(Info info);
    ValueTask<Info> UpdateInfoAsync(Info info);
    ValueTask<bool> DeleteInfoAysnyc(long id);
    ValueTask<Info> SelectInfoById(Predicate<Info> predicate);
    IQueryable<Info> SelectAllInfos();
}
