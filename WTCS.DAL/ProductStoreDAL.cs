using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL.Base;
using WTCS.DbUtility;
using WTCS.Models.DModels;

namespace WTCS.DAL
{
    public class ProductStoreDAL : BQuery<ProductStoreInfoModel>
    {

        /// <summary>
        /// 检查指定产品在指定分区中是否有库存
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public bool ExistProductStoreRecord(int productId, int sRegionId)
        {
            string strWhere = $" ProductId = {productId} and SRegionId = {sRegionId} ";
            return Exists(strWhere);
        }



        /// <summary>
        /// 添加产品库存记录
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        public bool AddProductToStore(ProductStoreInfoModel infoModel)
        {
            //添加产品库存记录
            //添加本次入库的入库记录

            string cols = CreateSql.GetColsString<ProductStoreInfoModel>("IsDeleted");
            string reCols = CreateSql.GetColsString<ProductInStoreRecordInfoModel>("InStoreTime,IsDeleted");

            SqlModel inStoreModel = CreateSql.GetInsertSqlAndParas<ProductStoreInfoModel>(infoModel, cols, 0);

            List<CommandInfo> commandList = new List<CommandInfo>();
            commandList.Add(new CommandInfo()
            {
                CommandText = inStoreModel.Sql,
                IsProc = false,
                Paras = inStoreModel.SqlParaArray

            });

            //入库记录信息
            ProductInStoreRecordInfoModel recordInfo = new ProductInStoreRecordInfoModel()
            {
                ProductId = infoModel.ProductId,
                SRegionId = infoModel.SRegionId,
                ProductCount = infoModel.ProductCount
            };

            SqlModel inRecordModel = CreateSql.GetInsertSqlAndParas<ProductInStoreRecordInfoModel>(recordInfo, reCols, 0);

            commandList.Add(new CommandInfo()
            {
                CommandText = inRecordModel.Sql,
                IsProc = false,
                Paras = inRecordModel.SqlParaArray

            });
            return SqlHelper.ExecuteTrans(commandList);
        }


        /// <summary>
        /// 修改产品处理
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        public bool UpdateProductToStore(ProductStoreInfoModel infoModel)
        {
            //修改产品数量
            //修改本次入库的入库记录

            string reCols = CreateSql.GetColsString<ProductInStoreRecordInfoModel>("InStoreTime,IsDeleted");

            string upDateSql = $"update ProductStoreInfos " +
                               $" set ProductCount = ProductCount + {infoModel.ProductCount} " +
                               $" where ProductId = {infoModel.ProductId} " +
                               $" and SRegionId = {infoModel.SRegionId} ";
            List<CommandInfo> commandList = new List<CommandInfo>();
            commandList.Add(new CommandInfo()
            {
                CommandText = upDateSql,
                IsProc = false,
            });

            //入库记录信息
            ProductInStoreRecordInfoModel recordInfo = new ProductInStoreRecordInfoModel()
            {
                ProductId = infoModel.ProductId,
                SRegionId = infoModel.SRegionId,
                ProductCount = infoModel.ProductCount
            };

            SqlModel inRecordModel = CreateSql.GetInsertSqlAndParas<ProductInStoreRecordInfoModel>(recordInfo, reCols, 0);

            commandList.Add(new CommandInfo()
            {
                CommandText = inRecordModel.Sql,
                IsProc = false,
                Paras = inRecordModel.SqlParaArray

            });
            return SqlHelper.ExecuteTrans(commandList);
        }
    }
}
