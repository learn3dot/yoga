/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGAlignSelfTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAlignSelfTest
    {
        [Test]
        public void Test_align_self_center()
        {
            YogaNode root = new YogaNode();
            root.Width = 100f;
            root.Height = 100f;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.Center;
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_end()
        {
            YogaNode root = new YogaNode();
            root.Width = 100f;
            root.Height = 100f;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_start()
        {
            YogaNode root = new YogaNode();
            root.Width = 100f;
            root.Height = 100f;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.FlexStart;
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_end_override_flex_start()
        {
            YogaNode root = new YogaNode();
            root.AlignItems = YogaAlign.FlexStart;
            root.Width = 100f;
            root.Height = 100f;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

    }
}