#region PDFsharp - A .NET library for processing PDF
//
// Authors:
//   Klaus Potzesny (mailto:Klaus.Potzesny@pdfsharp.com)
//
// Copyright (c) 2005-2009 empira Software GmbH, Cologne (Germany)
//
// http://www.pdfsharp.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

namespace PdfSharp.Drawing.BarCodes
{
  /// <summary>
  /// Specifies whether and how the text is displayed at the code area.
  /// </summary>
  public enum AnchorType
  {
    /// <summary>
    /// The anchor is located top left.
    /// </summary>
    TopLeft,

    /// <summary>
    /// The anchor is located top center.
    /// </summary>
    TopCenter,

    /// <summary>
    /// The anchor is located top right.
    /// </summary>
    TopRight,

    /// <summary>
    /// The anchor is located middle left.
    /// </summary>
    MiddleLeft,

    /// <summary>
    /// The anchor is located middle center.
    /// </summary>
    MiddleCenter,

    /// <summary>
    /// The anchor is located middle right.
    /// </summary>
    MiddleRight,

    /// <summary>
    /// The anchor is located bottom left.
    /// </summary>
    BottomLeft,

    /// <summary>
    /// The anchor is located bottom center.
    /// </summary>
    BottomCenter,
    
    /// <summary>
    /// The anchor is located bottom right.
    /// </summary>
    BottomRight,
  }
}
