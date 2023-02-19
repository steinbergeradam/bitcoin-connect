using System;
using System.Collections.Generic;

namespace BitcoinConnect.Models;

public partial class Comment
{
    public Guid CommentId { get; set; }

    public Guid PostId { get; set; }

    public string Body { get; set; } = null!;

    public Guid CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }
}
