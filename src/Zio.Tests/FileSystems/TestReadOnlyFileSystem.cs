﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using Zio.FileSystems;

namespace Zio.Tests.FileSystems;

public class TestReadOnlyFileSystem : TestFileSystemBase
{
    [Fact]
    public void TestCommonReadOnly()
    {
        var rofs = new ReadOnlyFileSystem(GetCommonMemoryFileSystem());
        AssertCommonReadOnly(rofs);
    }
}