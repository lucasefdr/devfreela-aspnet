﻿namespace DevFreela.Core.Common;

public abstract class BaseEntity
{
    public int Id { get; private set; }

    protected BaseEntity() { }
}
