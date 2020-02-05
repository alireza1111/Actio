﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get;  }
        public Guid UserId { get;  }
        public string Category { get;  }
        public string Name { get;  }
        public string Descripton { get;  }
        public DateTime CreatedAt { get;  }

        public ActivityCreated(Guid id, Guid userId, string category)
        {
            Id = id;
            UserId = userId;
            Category = category;
        }

        protected ActivityCreated()
        {
        }
    }
}
