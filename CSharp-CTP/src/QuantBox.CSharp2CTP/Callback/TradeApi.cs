﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class TradeApi:BaseApi
    {
        private fnOnErrRtnOrderAction _OnErrRtnOrderAction;
        private fnOnErrRtnOrderInsert _OnErrRtnOrderInsert;
        private fnOnErrRtnQuoteAction _OnErrRtnQuoteAction;
        private fnOnErrRtnQuoteInsert _OnErrRtnQuoteInsert;
        private fnOnRspOrderAction _OnRspOrderAction;
        private fnOnRspOrderInsert _OnRspOrderInsert;
        private fnOnRspQuoteAction _OnRspQuoteAction;
        private fnOnRspQuoteInsert _OnRspQuoteInsert;
        private fnOnRspQryDepthMarketData _OnRspQryDepthMarketData;
        private fnOnRspQryInstrument _OnRspQryInstrument;
        private fnOnRspQryInstrumentCommissionRate _OnRspQryInstrumentCommissionRate;
        private fnOnRspQryInstrumentMarginRate _OnRspQryInstrumentMarginRate;
        private fnOnRspQryInvestorPosition _OnRspQryInvestorPosition;
        private fnOnRspQryInvestorPositionDetail _OnRspQryInvestorPositionDetail;
        private fnOnRspQryOrder _OnRspQryOrder;
        private fnOnRspQryTrade _OnRspQryTrade;
        private fnOnRspQryTradingAccount _OnRspQryTradingAccount;
        private fnOnRtnInstrumentStatus _OnRtnInstrumentStatus;
        private fnOnRtnOrder _OnRtnOrder;
        private fnOnRtnQuote _OnRtnQuote;
        private fnOnRtnTrade _OnRtnTrade;

        public THOST_TE_RESUME_TYPE ResumeType = THOST_TE_RESUME_TYPE.THOST_TERT_QUICK;

        public fnOnErrRtnOrderAction OnErrRtnOrderAction
        {
            set
            {
                _OnErrRtnOrderAction = value;
                TraderApi.CTP_RegOnErrRtnOrderAction(_MsgQueue, _OnErrRtnOrderAction);
            }
        }

        public fnOnErrRtnOrderInsert OnErrRtnOrderInsert
        {
            set
            {
                _OnErrRtnOrderInsert = value;
                TraderApi.CTP_RegOnErrRtnOrderInsert(_MsgQueue, _OnErrRtnOrderInsert);
            }
        }

        public fnOnErrRtnQuoteAction OnErrRtnQuoteAction
        {
            set
            {
                _OnErrRtnQuoteAction = value;
                TraderApi.CTP_RegOnErrRtnQuoteAction(_MsgQueue, _OnErrRtnQuoteAction);
            }
        }

        public fnOnErrRtnQuoteInsert OnErrRtnQuoteInsert
        {
            set
            {
                _OnErrRtnQuoteInsert = value;
                TraderApi.CTP_RegOnErrRtnQuoteInsert(_MsgQueue, _OnErrRtnQuoteInsert);
            }
        }

        public fnOnRspOrderAction OnRspOrderAction
        {
            set
            {
                _OnRspOrderAction = value;
                TraderApi.CTP_RegOnRspOrderAction(_MsgQueue, _OnRspOrderAction);
            }
        }
        public fnOnRspOrderInsert OnRspOrderInsert
        {
            set
            {
                _OnRspOrderInsert = value;
                TraderApi.CTP_RegOnRspOrderInsert(_MsgQueue, _OnRspOrderInsert);
            }
        }

        public fnOnRspQuoteAction OnRspQuoteAction
        {
            set
            {
                _OnRspQuoteAction = value;
                TraderApi.CTP_RegOnRspQuoteAction(_MsgQueue, _OnRspQuoteAction);
            }
        }
        public fnOnRspQuoteInsert OnRspQuoteInsert
        {
            set
            {
                _OnRspQuoteInsert = value;
                TraderApi.CTP_RegOnRspQuoteInsert(_MsgQueue, _OnRspQuoteInsert);
            }
        }

        public fnOnRspQryDepthMarketData OnRspQryDepthMarketData
        {
            set
            {
                _OnRspQryDepthMarketData = value;
                TraderApi.CTP_RegOnRspQryDepthMarketData(_MsgQueue, _OnRspQryDepthMarketData);
            }
        }
        public fnOnRspQryInstrument OnRspQryInstrument
        {
            set
            {
                _OnRspQryInstrument = value;
                TraderApi.CTP_RegOnRspQryInstrument(_MsgQueue, _OnRspQryInstrument);
            }
        }
        public fnOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate
        {
            set
            {
                _OnRspQryInstrumentCommissionRate = value;
                TraderApi.CTP_RegOnRspQryInstrumentCommissionRate(_MsgQueue, _OnRspQryInstrumentCommissionRate);
            }
        }
        public fnOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate
        {
            set
            {
                _OnRspQryInstrumentMarginRate = value;
                TraderApi.CTP_RegOnRspQryInstrumentMarginRate(_MsgQueue, _OnRspQryInstrumentMarginRate);
            }
        }
        public fnOnRspQryInvestorPosition OnRspQryInvestorPosition
        {
            set
            {
                _OnRspQryInvestorPosition = value;
                TraderApi.CTP_RegOnRspQryInvestorPosition(_MsgQueue, _OnRspQryInvestorPosition);
            }
        }
        public fnOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail
        {
            set
            {
                _OnRspQryInvestorPositionDetail = value;
                TraderApi.CTP_RegOnRspQryInvestorPositionDetail(_MsgQueue, _OnRspQryInvestorPositionDetail);
            }
        }
        public fnOnRspQryOrder OnRspQryOrder
        {
            set
            {
                _OnRspQryOrder = value;
                TraderApi.CTP_RegOnRspQryOrder(_MsgQueue, _OnRspQryOrder);
            }
        }
        public fnOnRspQryTrade OnRspQryTrade
        {
            set
            {
                _OnRspQryTrade = value;
                TraderApi.CTP_RegOnRspQryTrade(_MsgQueue, _OnRspQryTrade);
            }
        }
        public fnOnRspQryTradingAccount OnRspQryTradingAccount
        {
            set
            {
                _OnRspQryTradingAccount = value;
                TraderApi.CTP_RegOnRspQryTradingAccount(_MsgQueue, _OnRspQryTradingAccount);
            }
        }
        public fnOnRtnInstrumentStatus OnRtnInstrumentStatus
        {
            set
            {
                _OnRtnInstrumentStatus = value;
                TraderApi.CTP_RegOnRtnInstrumentStatus(_MsgQueue, _OnRtnInstrumentStatus);
            }
        }
        public fnOnRtnOrder OnRtnOrder
        {
            set
            {
                _OnRtnOrder = value;
                TraderApi.CTP_RegOnRtnOrder(_MsgQueue, _OnRtnOrder);
            }
        }

        public fnOnRtnQuote OnRtnQuote
        {
            set
            {
                _OnRtnQuote = value;
                TraderApi.CTP_RegOnRtnQuote(_MsgQueue, _OnRtnQuote);
            }
        }

        public fnOnRtnTrade OnRtnTrade
        {
            set
            {
                _OnRtnTrade = value;
                TraderApi.CTP_RegOnRtnTrade(_MsgQueue, _OnRtnTrade);
            }
        }

        public TradeApi(IntPtr MsgQueue)
            : base(MsgQueue)
        {
            IntPtrKey = TraderApi.TD_CreateTdApi();
            TraderApi.TD_RegMsgQueue2TdApi(IntPtrKey, _MsgQueue);
        }

        public override void Connect()
        {
            base.Connect();

            TraderApi.TD_Connect(IntPtrKey, _TempPath,
                _Front.TradeAddress, _Front.BrokerId,
                _Account.InvestorId, _Account.Password,
                ResumeType,
                _Front.UserProductInfo, _Front.AuthCode);
        }

        public override void Disconnect()
        {
            if (null != IntPtrKey && IntPtr.Zero != IntPtrKey)
            {
                TraderApi.TD_RegMsgQueue2TdApi(IntPtrKey, IntPtr.Zero);
                TraderApi.TD_ReleaseTdApi(IntPtrKey);
                IntPtrKey = IntPtr.Zero;
            }

            base.Disconnect();
        }

        public int SendOrder(
            int OrderRef,
            string szInstrument,
            TThostFtdcDirectionType Direction,
            string szCombOffsetFlag,
            string szCombHedgeFlag,
            int VolumeTotalOriginal,
            double LimitPrice,
            TThostFtdcOrderPriceTypeType OrderPriceType,
            TThostFtdcTimeConditionType TimeCondition,
            TThostFtdcContingentConditionType ContingentCondition,
            double StopPrice,
            TThostFtdcVolumeConditionType VolumeCondition)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return 0;
            }

            return TraderApi.TD_SendOrder(
               IntPtrKey,
               OrderRef,
               szInstrument,
               Direction,
               szCombOffsetFlag,
               szCombHedgeFlag,
               VolumeTotalOriginal,
               LimitPrice,
               OrderPriceType,
               TimeCondition,
               ContingentCondition,
               StopPrice,
               VolumeCondition);
        }

        public void CancelOrder(ref CThostFtdcOrderField pOrder)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }

            TraderApi.TD_CancelOrder(IntPtrKey, ref pOrder);
        }

        public int SendQuote(
            int QuoteRef,
            string szInstrument,
            double AskPrice,
            double BidPrice,
            int AskVolume,
            int BidVolume,
            TThostFtdcOffsetFlagType AskOffsetFlag,
            TThostFtdcOffsetFlagType BidOffsetFlag,
            TThostFtdcHedgeFlagType AskHedgeFlag,
            TThostFtdcHedgeFlagType BidHedgeFlag)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return 0;
            }

            return TraderApi.TD_SendQuote(
                IntPtrKey,
                QuoteRef,
                szInstrument,
                AskPrice,
                BidPrice,
                AskVolume,
                BidVolume,
                AskOffsetFlag,
                BidOffsetFlag,
                AskHedgeFlag,
                BidHedgeFlag);
        }

        public void CancelQuote(ref CThostFtdcQuoteField pQuote)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }

            TraderApi.TD_CancelQuote(IntPtrKey, ref pQuote);
        }

        public void ReqQryTradingAccount()
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryTradingAccount(IntPtrKey);
        }

        public void ReqQryInvestorPositionDetail(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInvestorPositionDetail(IntPtrKey, szInstrument);
        }

        public void ReqQryInstrumentCommissionRate(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInstrumentCommissionRate(IntPtrKey, szInstrument);
        }

        public void ReqQryInstrumentMarginRate(string szInstrument, TThostFtdcHedgeFlagType HedgeFlag)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInstrumentMarginRate(IntPtrKey, szInstrument, HedgeFlag);
        }
    }
}
