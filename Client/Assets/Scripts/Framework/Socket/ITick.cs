﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

namespace LightingCat
{
    /// <summary>
    /// 需要定期调用
    /// </summary>
    internal interface ITick
    {
        /// <summary>
        /// 定时激活
        /// </summary>
        void Tick();
    }
}
