﻿namespace UnityEngine
{
    using System;
    using System.Runtime.InteropServices;

    public struct CharacterInfo
    {
        public int index;
        public Rect uv;
        public Rect vert;
        public float width;
        public int size;
        public FontStyle style;
        public bool flipped;
        private int ascent;
        public int advance
        {
            get
            {
                return (int) this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public int glyphWidth
        {
            get
            {
                return (int) this.vert.width;
            }
            set
            {
                this.vert.width = value;
            }
        }
        public int glyphHeight
        {
            get
            {
                return (int) -this.vert.height;
            }
            set
            {
                float height = this.vert.height;
                this.vert.height = -value;
                this.vert.y += height - this.vert.height;
            }
        }
        public int bearing
        {
            get
            {
                return (int) this.vert.x;
            }
            set
            {
                this.vert.x = value;
            }
        }
        public int minY
        {
            get
            {
                return (this.ascent + ((int) (this.vert.y + this.vert.height)));
            }
            set
            {
                this.vert.height = (value - this.ascent) - this.vert.y;
            }
        }
        public int maxY
        {
            get
            {
                return (this.ascent + ((int) this.vert.y));
            }
            set
            {
                float y = this.vert.y;
                this.vert.y = value - this.ascent;
                this.vert.height += y - this.vert.y;
            }
        }
        public int minX
        {
            get
            {
                return (int) this.vert.x;
            }
            set
            {
                float x = this.vert.x;
                this.vert.x = value;
                this.vert.width += x - this.vert.x;
            }
        }
        public int maxX
        {
            get
            {
                return (int) (this.vert.x + this.vert.width);
            }
            set
            {
                this.vert.width = value - this.vert.x;
            }
        }
        internal Vector2 uvBottomLeftUnFlipped
        {
            get
            {
                return new Vector2(this.uv.x, this.uv.y);
            }
            set
            {
                Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
                this.uv.x = value.x;
                this.uv.y = value.y;
                this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
                this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
            }
        }
        internal Vector2 uvBottomRightUnFlipped
        {
            get
            {
                return new Vector2(this.uv.x + this.uv.width, this.uv.y);
            }
            set
            {
                Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
                this.uv.width = value.x - this.uv.x;
                this.uv.y = value.y;
                this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
            }
        }
        internal Vector2 uvTopRightUnFlipped
        {
            get
            {
                return new Vector2(this.uv.x + this.uv.width, this.uv.y + this.uv.height);
            }
            set
            {
                this.uv.width = value.x - this.uv.x;
                this.uv.height = value.y - this.uv.y;
            }
        }
        internal Vector2 uvTopLeftUnFlipped
        {
            get
            {
                return new Vector2(this.uv.x, this.uv.y + this.uv.height);
            }
            set
            {
                Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
                this.uv.x = value.x;
                this.uv.height = value.y - this.uv.y;
                this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
            }
        }
        public Vector2 uvBottomLeft
        {
            get
            {
                return this.uvBottomLeftUnFlipped;
            }
            set
            {
                this.uvBottomLeftUnFlipped = value;
            }
        }
        public Vector2 uvBottomRight
        {
            get
            {
                return (!this.flipped ? this.uvBottomRightUnFlipped : this.uvTopLeftUnFlipped);
            }
            set
            {
                if (this.flipped)
                {
                    this.uvTopLeftUnFlipped = value;
                }
                else
                {
                    this.uvBottomRightUnFlipped = value;
                }
            }
        }
        public Vector2 uvTopRight
        {
            get
            {
                return this.uvTopRightUnFlipped;
            }
            set
            {
                this.uvTopRightUnFlipped = value;
            }
        }
        public Vector2 uvTopLeft
        {
            get
            {
                return (!this.flipped ? this.uvTopLeftUnFlipped : this.uvBottomRightUnFlipped);
            }
            set
            {
                if (this.flipped)
                {
                    this.uvBottomRightUnFlipped = value;
                }
                else
                {
                    this.uvTopLeftUnFlipped = value;
                }
            }
        }
    }
}

