﻿using System;

using Bridge;

namespace Bridge.Html5
{
    /// <summary>
    /// The Comment interface represents textual notations within markup; although it is generally not visually shown, such comments are available to be read in the source view. Comments are represented in HTML and XML as content between '<!--' and '-->'. In XML, the character sequence '--' cannot be used within a comment.
    /// </summary>
    [Ignore]
    [Name("Comment")]
    public class Comment : CharacterData
    {
        public Comment()
        {
        }

        public Comment(string data) 
        {
		}
    }
}