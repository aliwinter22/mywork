
        internal string DebugDisplayString
        {
            get
            {
                return string.Concat(
                    "Center( ", this.Center.DebugDisplayString, " )  \r\n",
                    "Radius( ", this.Radius.ToString(), " )"
                    );
            }
        }
//hi
     public ContainmentType Contains(BoundingBox box)
        {

            bool inside = true;
            foreach (Vector3 corner in box.GetCorners())
            {
                if (this.Contains(corner) == ContainmentType.Disjoint)
                {
                    inside = false;
                    break;
                }
            }

            if (inside)
                return ContainmentType.Contains;

        private CurveContinuity _continuity;
        private readonly float _position;
        private float _tangentIn;
        private float _tangentOut;
        private float _value;
