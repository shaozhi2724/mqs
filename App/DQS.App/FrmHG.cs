using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.App
{
    public partial class FrmHG : XtraForm
    {
        public FrmHG()
        {
            InitializeComponent();
        }

        private void btnChangReason_Click(object sender, EventArgs e)
        {
            using (FrmChangeReason frm = new FrmChangeReason())
            {
                frm.ShowDialog();
            }
        }

        /*
         * sql
ALTER PROC sp_Repair_Review 
@billCode NVARCHAR(50)
AS
    DECLARE @storecode NVARCHAR(50) = ( SELECT  StoreCode
                                        FROM    dbo.BUS_StoreBill
                                        WHERE   SaleBillCode = @billCode
                                      );
    DECLARE @billid INT = ( SELECT  BillID
                            FROM    dbo.BUS_Bill
                            WHERE   BillCode = @billCode
                          ) ,
        @storeid INT = ( SELECT StoreID
                         FROM   dbo.BUS_StoreBill
                         WHERE  SaleBillCode = @billCode
                       ) ,
        @reviewid INT = ( SELECT    ReviewID
                          FROM      dbo.BUS_StoreBill
                          WHERE     SaleBillCode = @billCode
                        ) ,
        @datetime NVARCHAR(50) = ( SELECT TOP 1 ReviewDate
                                   FROM     WMS_StoreOutReviewIdentity
                                   WHERE    StoreCode = @storecode
                                 ) ,
        @reviewperson NVARCHAR(50) = ( SELECT TOP 1 ReviewPerson
                                       FROM     WMS_StoreOutReviewIdentity
                                       WHERE    StoreCode = @storecode
                                     );

    IF ( @datetime IS NULL
         OR @reviewperson IS NULL
       )
        BEGIN
    --删除复核记录
            DELETE  dbo.BUS_Review
            WHERE   ReviewID = @reviewid;
            DELETE  dbo.BUS_ReviewDetail
            WHERE   ReviewID = @reviewid;
            DELETE  dbo.WMS_ReviewHistory
            WHERE   ReviewID = @reviewid;
            UPDATE  dbo.BUS_StoreBill
            SET     ReceiveID = NULL ,
                    ReviewCode = NULL
            WHERE   StoreCode = @storecode;
        END;
    ELSE
        BEGIN
--添加复核记录
            SET IDENTITY_INSERT BUS_Review ON;
            INSERT  BUS_Review
                    ( ReviewID ,
                      ReviewCode ,
                      ReviewDate ,
                      ReviewPerson ,
                      StatusID ,
                      StatusName ,
                      SaleBillID ,
                      SaleBillCode ,
                      StoreOutID ,
                      StoreOutCode ,
                      CreateDate ,
                      Reservation1
                    )
            VALUES  ( @reviewid ,
                      @billCode ,
                      @datetime ,
                      @reviewperson ,
                      1 ,
                      '复核成功' ,
                      @billid , --billid
                      @billCode ,
                      @storeid , --storeid
                      @billCode ,
                      @datetime ,
                      '1'
                    );
            SET IDENTITY_INSERT BUS_Review OFF;

            INSERT  BUS_ReviewDetail
                    ( ReviewID ,
                      ProductID ,
                      BatchNo ,
                      ProduceDate ,
                      ValidateDate ,
                      Amount ,
                      ReviewAmount ,
                      ReviewResult ,
                      CreateDate
                    )
                    SELECT  @reviewid ,
                            ProductID ,
                            BatchNo ,
                            ProduceDate ,
                            ValidateDate ,
                            Amount ,
                            Amount ,
                            '合格' ,
                            @datetime
                    FROM    BUS_StoreBillDetail
                    WHERE   StoreID = @storeid;--StoreID

            INSERT  WMS_ReviewHistory
                    ( ReviewID ,
                      DetailID ,
                      ProductID ,
                      BatchNo ,
                      ProduceDate ,
                      ValidateDate ,
                      Amount ,
                      ReviewAmount ,
                      ReviewResult ,
                      CreateDate
                    )
                    SELECT  ReviewID ,
                            DetailID ,
                            ProductID ,
                            BatchNo ,
                            ProduceDate ,
                            ValidateDate ,
                            Amount ,
                            ReviewAmount ,
                            ReviewResult ,
                            CreateDate
                    FROM    BUS_ReviewDetail
                    WHERE   ReviewID = @reviewid;--ReviewID
        END;
GO

*/
        private void btnReview_Click(object sender, EventArgs e)
        {
            using (FrmReview frm = new FrmReview())
            {
                frm.ShowDialog();
            }
        }

        private void btnRepairStore_Click(object sender, EventArgs e)
        {
            using (FrmRepairStore frm = new FrmRepairStore())
            {
                frm.ShowDialog();
            }
        }

        private void btnInStore_Click(object sender, EventArgs e)
        {
            using (FrmInStore frm = new FrmInStore())
            {
                frm.ShowDialog();
            }
        }

        private void btnDateUpdate_Click(object sender, EventArgs e)
        {
            using (FrmDateUpdate frm = new FrmDateUpdate())
            {
                frm.ShowDialog();
            }
        }
    }
}
