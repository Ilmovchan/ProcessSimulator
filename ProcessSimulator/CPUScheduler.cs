﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class CPUScheduler
    {

        public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public PriorityQueue<Process, long> Session()
        {
            resource.ActiveProcess = queue.Peek;

        }

        private Resource resource;
        private PriorityQueue<Process, long> queue;
    }
}
