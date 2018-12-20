using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SnowLeopard.Model.Memory
{
    public class Vehicle : TreeNodeEx
    {
        #region 私有变量

        private string _sCarStatus = "";//OffLine;
        private string _sOrgName = string.Empty;

        private string _sAddress = "正在解析位置信息，请稍候...";
        private string _sLongitude = string.Empty;
        private string _sLatitude = string.Empty;
        private string _sSpeed = "";
        private string _sDirect = "";
        private string _sADRSpeed = "";
        private string _sLimitSpeed = "";

        private string _sLastAlarmStopTime = DateTime.MinValue.ToString("yyyy-MM-hh HH:mm:ss");
        private string _sLastAlarmSetTime = DateTime.MinValue.ToString("yyyy-MM-hh HH:mm:ss");

        private int _iPromptDays = 0;
        private int _iTotalDriveTime = 0;
        private int _iTotalIdleTime = 0;
        private int _iTotalOtherTime = 0;
        private int _iTotalEngineWorkTime = 0;
        private double _dTotalDriveFuel = 0;
        private double _dTotalIdleFuel = 0;
        private double _dTotalOtherFuel = 0;
        private double _dTotalFuel = 0;
        private double _dInstantHundredKmFuel = 0;
        private double _dInstantHourlyFuel = 0;
        private double _dMaxInstantHourlyFuel = 0;
        private int _iLastTotalDriveTime = 0;
        private int _iLastTotalIdleTime = 0;
        private int _iLastTotalOtherTime = 0;
        private int _iLastTotalEngineWorkTime = 0;
        private double _dLastTotalDriveFuel = 0;
        private double _dLastTotalIdleFuel = 0;
        private double _dLastTotalOtherFuel = 0;
        private double _dLastTotalFuel = 0;
        private double _dLastInstantHundredKmFuel = 0;
        private double _dLastInstantHourlyFuel = 0;
        private string _sRepairStatus = "";
        private string _sOilDescription = "";
        //private FuelInfo _fuelInfo = null;
        private bool _bIsOnline = false;
        private bool _bIsAutoFrozen = false;
        private bool _bIsTravel = false;
        #endregion

        #region 属性

        //public static string OnLine = Variable.VehicleOnlineIcon;
        //public static string OffLine = Variable.VehicleOffLineIcon;
        //public static string Alarm = Variable.VehicleAlarmIcon;
        //public static string Fill = Variable.VehicleFillIcon;

        /// <summary>
        /// 车辆编号
        /// </summary>
        public string VehicleId { get; set; }

        /// <summary>
        /// 车辆密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 终端ID
        /// </summary>
        public string TerminalId { get; set; }


        /// <summary>
        /// 车载电话，作为节点的Name
        /// </summary>
        public string SimNum
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        /// <summary>
        /// 真实Sim卡号
        /// </summary>
        public string RealSimNum { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        public string PlateNum { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        public string PlateColor { get; set; }

        /// <summary>
        /// 车辆颜色
        /// </summary>
        public string VehicleColor { get; set; }

        /// <summary>
        /// 终端序列号
        /// </summary>
        public string TermSerial { get; set; }

        /// <summary>
        /// 终端型号
        /// </summary>
        public string TerminalModel { get; set; }

        /// <summary>
        /// 车辆是处于报警状态 true 报警false 正常
        /// </summary>
        public bool IsAlarm { get; set; }

        /// <summary>
        /// 车辆报警信息id 多个是以','分隔
        /// </summary>
        public string AlarmInfoId { get; set; }

        /// <summary>
        /// 车辆图标状态
        /// </summary>
        public string VehicleStatus
        {
            get { return _sCarStatus; }
            set
            {
                SetVehicleOnline(value);
                _sCarStatus = value;
            }
        }

        /// <summary>
        /// 车辆状态名称
        /// </summary>
        public string VehicleStatusName { get; set; }

        /// <summary>
        /// 报警状态名称
        /// </summary>
        public string VehicleAlarmStatus { get; set; }

        /// <summary>
        /// 车辆运输行业类型 
        /// </summary>
        public string TransType { get; set; }
        /// <summary>
        /// 车辆运输行业类型 
        /// </summary>
        public string TransTypeName { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        public string VehicleType { get; set; }

        /// <summary>
        /// 设置运营状态
        /// </summary>
        public bool IsFill { get; set; }

        /// <summary>
        /// 所属组织名称
        /// </summary>
        public string VehicleOrgName
        {
            get
            {
                if (string.IsNullOrEmpty(_sOrgName))
                {
                    try
                    {
                        //if (this.Parent != null)
                        //{
                        //    _sOrgName = (this.Parent as Org).OrgName;
                        //}
                    }
                    catch { }
                }
                return _sOrgName;
            }
            set { _sOrgName = value; }
        }

        /// <summary>
        /// ACC状态
        /// </summary>
        public string AccOn { get; set; }

        /// <summary>
        /// 方向角
        /// </summary>
        public string Direction
        {
            get
            {
                if (string.IsNullOrEmpty(_sDirect))
                {
                    return _sDirect;
                }
                else
                {
                    return string.Format("正北{0}度", _sDirect);
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.IndexOf('.') > 0)
                {
                    value = value.Substring(0, value.IndexOf('.'));
                }
                _sDirect = value;
            }
        }

        /// <summary>
        /// 卫星状态
        /// </summary>
        public string GpsValid { get; set; }
        /// <summary>
        /// 星数
        /// </summary>
        public string StarCount { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude
        {
            get
            {
                return _sLongitude;
            }
            set
            {
                if (!_sLongitude.Equals(value))
                {
                    if (!string.IsNullOrEmpty(value) && value.Length >= 10)//存在传入异常值
                    {
                        int iLength = value.IndexOf('.') + 7;
                        if (iLength > value.Length)
                            iLength = value.Length;
                        value = value.Substring(0, iLength);
                    }
                    _sLongitude = value;
                    PlaceChanged = true;
                }
            }
        }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude
        {
            get
            {
                return _sLatitude;
            }
            set
            {
                if (!_sLatitude.Equals(value))
                {
                    if (!string.IsNullOrEmpty(value) && value.Length >= 9)//存在异常数据
                    {
                        int iLength = value.IndexOf('.') + 7;
                        if (iLength > value.Length)
                            iLength = value.Length;
                        value = value.Substring(0, iLength);
                    }

                    _sLatitude = value;
                    PlaceChanged = true;
                }
            }
        }

        /// <summary>
        /// 报警类型
        /// </summary>
        public string AlarmType { get; set; }

        /// <summary>
        /// 上报时间
        /// </summary>
        public string ReceTime { get; set; }

        /// <summary>
        /// 定位时间
        /// </summary>
        public string GpsTime { get; set; }

        /// <summary>
        /// 速度值
        /// </summary>
        public float SpeedValue
        {
            get
            {
                float fSpeed;
                if (float.TryParse(_sSpeed, out fSpeed))
                    return fSpeed;
                return 0.0f;
            }
        }

        /// <summary>
        /// 速度
        /// </summary>
        public string Speed
        {
            get
            {
                if (!string.IsNullOrEmpty(_sSpeed))
                {
                    return string.Format("{0}km/h", _sSpeed);
                }
                else
                {
                    return "0.0km/h";
                }
            }
            set
            {
                //if (!string.IsNullOrEmpty(value))
                //{
                //    value = value.Substring(0, value.IndexOf('.') + 3);
                //}
                if (!string.IsNullOrEmpty(value))
                {
                    _sSpeed = double.Parse(value).ToString("#0.0");
                }
                else
                {
                    _sSpeed = value;
                }
            }
        }
        /// <summary>
        /// 脉冲速度
        /// </summary>
        public string ADRSpeed
        {
            get
            {
                if (!string.IsNullOrEmpty(_sADRSpeed))
                {
                    return string.Format("{0}km/h", _sADRSpeed);
                }
                else
                {
                    return "0.0km/h";
                }
            }
            set
            {
                //if (!string.IsNullOrEmpty(value))
                //{
                //    _sADRSpeed = value.Substring(0, value.IndexOf('.') + 3);
                //}
                //else
                //{
                if (!string.IsNullOrEmpty(value))
                {
                    _sADRSpeed = double.Parse(value).ToString("#0.0");
                }
                else
                {
                    _sADRSpeed = value;
                }
                //}
            }
        }

        public float LimitSpeedValue
        {
            get
            {
                float fSpeed;
                if (float.TryParse(_sLimitSpeed, out fSpeed))
                    return fSpeed;
                else
                {
                    Match match = Regex.Match(_sLimitSpeed, @"[\d]+[\.]?[\d]*");
                    if (match.Success)
                    {
                        return float.Parse(match.Value);
                    }
                }
                return 0.0f;
            }
        }

        /// <summary>
        /// 限制速度
        /// </summary>
        public string LimitSpeed
        {
            get
            {
                if (!string.IsNullOrEmpty(_sLimitSpeed))
                {
                    return _sLimitSpeed;
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    double dValue = 0;
                    if (double.TryParse(value, out dValue))
                        _sLimitSpeed = dValue.ToString("#0");
                    else
                        _sLimitSpeed = value;
                }
                else
                {
                    _sLimitSpeed = value;
                }
            }
        }
        /// <summary>
        /// 当前位置
        /// </summary>
        public string Address
        {
            get
            {
                if (string.IsNullOrEmpty(Longitude) || IsNotShowPos)
                {
                    return "";
                }
                return _sAddress;
            }
            set
            {
                _sAddress = value;
            }
        }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        public DateTime ServerStartTime { get; set; }

        public string ServerStartTimeDesc
        {
            get
            {
                if (ServerStartTime <= default(DateTime))
                    return "";
                return ServerStartTime.ToString("yyyy-MM-dd");
            }
        }

        private DateTime _dtmServerEnd;

        /// <summary>
        /// 服务到期时间
        /// </summary>
        public DateTime ServerEndTime
        {
            get
            {
                return _dtmServerEnd;
            }
            set
            {
                if (_dtmServerEnd != value)
                {
                    //车辆状态表 服务状态
                    if (value > default(DateTime))
                    {
                        //TimeSpan tsServerTime = value - ServerTimeHelper.Instant.ServerTime;
                        //if (value.Date == ServerTimeHelper.Instant.ServerTime.Date)
                        //{
                        //    ServerStatuFlag = 2;
                        //    ServerStatu = "服务今日到期";
                        //}
                        //else if (tsServerTime.TotalDays > 0 && tsServerTime.TotalDays <= PromptDays)
                        //{
                        //    ServerStatuFlag = 1;
                        //    ServerStatu = string.Format("服务剩余{0}天", tsServerTime.Days + 1);
                        //}
                        //else if (tsServerTime.TotalDays > PromptDays)
                        //{
                        //    ServerStatuFlag = 0;
                        //    ServerStatu = string.Format("服务剩余{0}天", tsServerTime.Days + 1);
                        //}
                        //else if (tsServerTime.TotalDays < 0)
                        //{
                        //    ServerStatuFlag = 2;
                        //    ServerStatu = string.Format("服务到期{0}天", Math.Abs(tsServerTime.Days));
                        //}
                        //else
                        //    ServerStatu = "";
                    }
                    else
                        ServerStatu = "";
                }
                _dtmServerEnd = value;
            }
        }

        public string ServerEndTimeDesc
        {
            get
            {
                if (ServerEndTime <= default(DateTime))
                    return "";
                return ServerEndTime.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// 服务到期提前提醒天数
        /// </summary>
        public int PromptDays
        {
            get
            {
                return _iPromptDays == 0 ? 30 : _iPromptDays;
            }
            set
            {
                _iPromptDays = value;
            }
        }

        public string ServerEndNotice
        {
            get
            {
                //if (!_bIsAutoFrozen || !Variable.IsAutoFrozenVehicle)
                //    return string.Empty;
                if (IsFrozen)
                    return "【服务已到期】";
                else if (ServerStatuFlag == 1 || ServerStatu == "服务今日到期")
                    return string.Format("【{0}】", ServerStatu);
                else
                    return string.Empty;
            }
        }

        /// <summary>
        /// 是否已冻结 ,到期的为：true，否则为：false
        /// </summary>
        public override bool IsFrozen
        {
            get
            {
                //if (!_bIsAutoFrozen || !Variable.IsAutoFrozenVehicle)
                    return false;
                //return ServerEndTime != default(DateTime) && ServerEndTime.Date < ServerTimeHelper.Instant.ServerTime.Date;
            }
        }

        /// <summary>
        /// 服务状态（显示服务剩余xx天，服务到期xx天）
        /// </summary>
        public string ServerStatu
        {
            get;
            set;
        }

        /// <summary>
        /// 服务状态提醒标识（0：正常，1：服务剩余，2：服务到期）
        /// </summary>
        public int ServerStatuFlag { get; set; }

        public bool IsNotShowPos
        {
            get
            {
                return !string.IsNullOrEmpty(TransportStatus) && TransportStatus.Contains("停运");
            }
        }

        /// <summary>
        /// 终端类型
        /// </summary>
        public string TerminalType { get; set; }

        private string _sAllDiff = "";

        public float MileageValue
        {
            get
            {
                float fMileage;
                if (float.TryParse(_sAllDiff, out fMileage))
                    return fMileage;
                return 0.0f;
            }
        }

        /// <summary>
        /// 总里程
        /// </summary>
        public string Mileage
        {
            get
            {
                if (string.IsNullOrEmpty(_sAllDiff))
                {
                    _sAllDiff = "0.00";
                }
                return string.Format("{0}公里", _sAllDiff);
            }
            set
            {
                //转为千米
                if (value.Length == 0)
                {
                    { value = "0.00"; }
                }
                else
                {
                    //int iIndex = value.IndexOf('.');
                    //if (iIndex >= 0)
                    //{
                    //    value = value.Remove(iIndex, 1);
                    //    if (iIndex == 3) value = "0." + value;
                    //    else if (iIndex == 2) value = "0.0" + value;
                    //    else if (iIndex == 1) value = "0.00" + value;
                    //    else if (iIndex == 0) value = "0.000" + value;
                    //    else
                    //    {
                    //        value = value.Insert(iIndex - 3, ".");
                    //    }
                    //    value = value.Substring(0, value.IndexOf('.')+3);
                    //}
                }
                _sAllDiff = value;
            }
        }

        /// <summary>
        /// 位置是否变更
        /// </summary>
        public bool PlaceChanged { get; set; }

        private string _sPlace = "";

        /// <summary>
        /// 位置信息 -- 作用于县市
        /// </summary>
        public string Place
        {
            get
            {
                return _sPlace;
            }
            set
            {
                if ("波阳县".Equals(value))
                    _sPlace = "鄱阳县";
                else
                    _sPlace = value;
            }
        }

        /// <summary>
        /// 设置停止报警应答时间
        /// </summary>
        public string LastAlarmStopTime
        {
            get { return _sLastAlarmStopTime; }
            set { _sLastAlarmStopTime = value; }
        }

        /// <summary>
        /// 设置报警列表时间
        /// </summary>
        public string LastAlarmSetTime
        {
            get { return _sLastAlarmSetTime; }
            set { _sLastAlarmSetTime = value; }
        }

        bool _bIsLongTimeDropReminded = false;
        /// <summary>
        /// 是否已经长时间掉线提醒过了  --  用于避免同一次掉线多次提醒
        /// </summary>
        public bool IsLongTimeDropReminded
        {
            get { return _bIsLongTimeDropReminded; }
            set { _bIsLongTimeDropReminded = value; }
        }

        /// <summary>
        /// 车辆长时间掉线时间值
        /// </summary>
        public int LongTimeDropLimitValue
        {
            get;
            set;
        }

        /// <summary>
        /// 驾驶员证号
        /// </summary>
        public string DriverCode { get; set; }

        /// <summary>
        /// 驾驶员姓名
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string DriverLicense { get; set; }
        ///// <summary>
        ///// 当前驾驶员驾驶证号 终端上报
        ///// </summary>
        //public string CurrentDriverCode { get; set; }

        ///// <summary>
        ///// 当前驾驶员姓名 终端上报
        ///// </summary>
        //public string CurrentDriverName { get; set; }

        /// <summary>
        /// 当前驾驶员
        /// </summary>
        //public DriverInfo CurrentDriver { get; set; }

        private string _sBindDriverName = "";
        /// <summary>
        /// 绑定驾驶员（包含多个）
        /// </summary>
        public string BindDriverName
        {
            get
            {
                return _sBindDriverName;
            }
            set
            {
                if (value.EndsWith(","))
                {
                    value = value.TrimEnd(',');
                }
                _sBindDriverName = value;
            }
        }

        private string _BindDriverTelephone = "";

        /// <summary>
        /// 绑定驾驶员电话（多个和驾驶员对应）
        /// </summary>
        public string BindDriverTelephone
        {
            get
            {
                return _BindDriverTelephone;
            }
            set
            {
                if (value.EndsWith(","))
                {
                    value = value.TrimEnd(',');
                }
                _BindDriverTelephone = value;
            }
        }
        /// <summary>
        /// 驾驶员名称经过模式筛选显示
        /// </summary>
        public string DriverNameFilte
        {
            get
            {
                //if (Variable.ShowDriverMode.Equals("1"))
                {
                    return BindDriverName;
                }
                //else if (Variable.ShowDriverMode.Equals("2"))
                //{
                //    return CurrentDriver.DriverName;
                //}
                //else
                //{
                //    return CurrentDriver.DriverName == "" ? BindDriverName : CurrentDriver.DriverName;
                //}
            }
        }

        /// <summary>
        /// 驾驶员电话经过模式筛选显示
        /// </summary>
        public string DriverTelephoneFilter
        {
            get
            {
                //if (Variable.ShowDriverMode.Equals("1"))
                    return BindDriverTelephone;
                //else if (Variable.ShowDriverMode.Equals("2"))
                //    return CurrentDriver.DriverTelephone;
                //else
                //{
                //    return CurrentDriver.DriverTelephone == "" ? BindDriverTelephone : CurrentDriver.DriverTelephone;
                //}
            }
        }

        /// <summary>
        /// 海拔高度
        /// </summary>
        public string Altitude { get; set; }
        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 运营状态
        /// </summary>
        public string TransportStatus { get; set; }

        /// <summary>
        /// 时间下的运营状态
        /// </summary>
        public string TransportStatusByTime { get; set; }

        /// <summary>
        /// 所属行业 --- 经营类别  -- 车辆营运类型
        /// </summary>
        public string OperateTypeName { get; set; }
        /// <summary>
        /// 详细信息-最新位置
        /// </summary>
        public string CurrentDescribe { get; set; }
        /// <summary>
        /// 流水号-最新位置
        /// </summary>
        public string CurrentOrderId { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        //public bool IsOnline { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool IsOnline
        {
            get
            {
                return _bIsOnline;
            }
            set
            {
                if (this.TreeView == null || !this.TreeView.InvokeRequired)
                    UpdateOrgCount(value);
                else
                {
                    this.TreeView.Invoke(new MethodInvoker(() =>
                    {
                        UpdateOrgCount(value);
                    }));
                }
                _bIsOnline = value;
            }
        }

        /// <summary>
        /// 车辆是否在行驶(目前判断：车辆在线，且速度大于0)
        /// </summary>
        public bool IsTravel
        {
            get
            {
                return _bIsTravel;
            }
            set
            {
                if (_bIsTravel == value)
                    return;
                if (!value && _bIsTravel)//切换为停车
                {
                    UpdateLastParkTime();

                }
                if (!this.TreeView.InvokeRequired)
                    UpdateTravelCount(value);
                else
                {
                    this.TreeView.Invoke(new MethodInvoker(() =>
                    {
                        UpdateTravelCount(value);
                    }));
                }
                _bIsTravel = value;
            }
        }

        /// <summary>
        /// 是否维修
        /// </summary>
        [DefaultValue(false)]
        public bool IsRepair { get; set; }

        /// <summary>
        /// 维修状态 -1：无， 0：派单，1：开始维修，2：结束维修  --更改为文字显示  维修 派单
        /// </summary>
        public string RepairStatus
        {
            get
            {
                return _sRepairStatus;
            }
            set
            {
                _sRepairStatus = value;
            }
        }

        /// <summary>
        /// 剩余油量
        /// </summary>
        public string ResidualFuel { get; set; }

        #region 油耗版本
        /// <summary>
        /// 油耗类别 0 未安装 1 车辆油耗仪  2 设备油耗仪
        /// </summary> 
        public string OilMeterType
        {
            get;
            set;
        }

        /// <summary>
        /// 行驶时长 （单位:秒）
        /// </summary>
        public int TotalDriveTime
        {
            get { return _iTotalDriveTime; }
            set
            {
                if (value > 0)
                {
                    _iTotalDriveTime = value;
                }
            }
        }

        /// <summary>
        /// 怠速时长 （单位:秒）
        /// </summary>
        public int TotalIdleTime
        {
            get { return _iTotalIdleTime; }
            set
            {
                if (value > 0)
                {
                    _iTotalIdleTime = value;
                }
            }
        }

        /// <summary>
        /// 其他工作时长 （单位:秒）
        /// </summary>
        public int TotalOtherTime
        {
            get { return _iTotalOtherTime; }
            set
            {
                if (value > 0)
                {
                    _iTotalOtherTime = value;
                }
            }
        }

        /// <summary>
        /// 累计工作时长 （单位:秒）
        /// </summary>
        public int TotalEngineWorkTime
        {
            get { return _iTotalEngineWorkTime; }
            set
            {
                if (value > 0)
                {
                    _iTotalEngineWorkTime = value;
                }
            }
        }

        /// <summary>
        /// 累计行驶油耗 （单位:升）
        /// </summary>
        public double TotalDriveFuel
        {
            get { return _dTotalDriveFuel; }
            set
            {
                if (value > 0)
                {
                    _dTotalDriveFuel = value;
                }
            }
        }

        /// <summary>
        /// 累计怠速油耗 （单位:升）
        /// </summary>
        public double TotalIdleFuel
        {
            get { return _dTotalIdleFuel; }
            set
            {
                if (value > 0)
                {
                    _dTotalIdleFuel = value;
                }
            }
        }

        /// <summary>
        /// 累计其他油耗 （单位:升）
        /// </summary>
        public double TotalOtherFuel
        {
            get { return _dTotalOtherFuel; }
            set
            {
                if (value > 0)
                {
                    _dTotalOtherFuel = value;
                }
            }
        }

        /// <summary>
        /// 累计油耗 （单位:升）
        /// </summary>
        public double TotalFuel
        {
            get { return _dTotalFuel; }
            set
            {
                if (value > 0)
                {
                    _dTotalFuel = value;
                }
            }
        }

        /// <summary>
        /// 瞬时百公里油耗 （单位:升/百公里）
        /// </summary>
        public double InstantHundredKmFuel
        {
            get { return _dInstantHundredKmFuel; }
            set
            {
                if (value > 0)
                {
                    _dInstantHundredKmFuel = value;
                }
            }
        }

        /// <summary>
        /// 瞬时小时油耗 单位（升/小时）
        /// </summary>
        public double InstantHourlyFuel
        {
            get { return _dInstantHourlyFuel; }
            set
            {
                if (value > 0)
                {
                    _dInstantHourlyFuel = value;
                }
            }
        }

        /// <summary>
        /// 最大瞬时小时油耗  当日的最大瞬时小时油耗     //（当日、近两日、本周），单位：升/小时
        /// </summary>
        public double MaxInstantHourlyFuel
        {
            get { return _dMaxInstantHourlyFuel; }
            set
            {
                if (value > 0)
                {
                    _dMaxInstantHourlyFuel = value;
                }
            }
        }

        //添加最后一条相关字段  用于区分当前与最后一条油耗的车辆信息

        /// <summary>
        /// 最后一条油耗数据行驶时长 （单位:秒）
        /// </summary>
        public int LastTotalDriveTime
        {
            get { return _iLastTotalDriveTime; }
            set
            {
                if (value > 0)
                {
                    _iLastTotalDriveTime = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据怠速时长 （单位:秒）
        /// </summary>
        public int LastTotalIdleTime
        {
            get { return _iLastTotalIdleTime; }
            set
            {
                if (value > 0)
                {
                    _iLastTotalIdleTime = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据其他工作时长 （单位:秒）
        /// </summary>
        public int LastTotalOtherTime
        {
            get { return _iLastTotalOtherTime; }
            set
            {
                if (value > 0)
                {
                    _iLastTotalOtherTime = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据累计工作时长 （单位:秒）
        /// </summary>
        public int LastTotalEngineWorkTime
        {
            get { return _iLastTotalEngineWorkTime; }
            set
            {
                if (value > 0)
                {
                    _iLastTotalEngineWorkTime = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据累计行驶油耗 （单位:升）
        /// </summary>
        public double LastTotalDriveFuel
        {
            get { return _dLastTotalDriveFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastTotalDriveFuel = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据累计怠速油耗 （单位:升）
        /// </summary>
        public double LastTotalIdleFuel
        {
            get { return _dLastTotalIdleFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastTotalIdleFuel = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据累计其他油耗 （单位:升）
        /// </summary>
        public double LastTotalOtherFuel
        {
            get { return _dLastTotalOtherFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastTotalOtherFuel = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据累计油耗 （单位:升）
        /// </summary>
        public double LastTotalFuel
        {
            get { return _dLastTotalFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastTotalFuel = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据瞬时百公里油耗 （单位:升/百公里）
        /// </summary>
        public double LastInstantHundredKmFuel
        {
            get { return _dLastInstantHundredKmFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastInstantHundredKmFuel = value;
                }
            }
        }

        /// <summary>
        /// 最后一条油耗数据瞬时小时油耗 单位（升/小时）
        /// </summary>
        public double LastInstantHourlyFuel
        {
            get { return _dLastInstantHourlyFuel; }
            set
            {
                if (value > 0)
                {
                    _dLastInstantHourlyFuel = value;
                }
            }
        }

        private string _sLastMileageOfFuel;
        private string _sLastSpeedOfFuel;
        /// <summary>
        /// 最后一条油耗数据的里程
        /// </summary>
        public string LastMileageOfFuel
        {
            get
            {
                if (string.IsNullOrEmpty(_sLastMileageOfFuel))
                {
                    _sLastMileageOfFuel = "0.00";
                }
                return string.Format("{0}公里", _sLastMileageOfFuel);
            }
            set
            {
                //转为千米
                if (string.IsNullOrEmpty(value))
                {
                    { value = "0.00"; }
                }
                _sLastMileageOfFuel = value;
            }
        }

        /// <summary>
        /// 最后一条油耗数据的卫星时间
        /// </summary>
        public string LastGpsTimeOfFuel
        {
            get;
            set;
        }

        /// <summary>
        /// 最后一条油耗数据的速度
        /// </summary>
        public string LastSpeedOfFuel
        {
            get
            {
                if (!string.IsNullOrEmpty(_sLastSpeedOfFuel))
                {
                    return string.Format("{0}km/h", _sLastSpeedOfFuel);
                }
                else
                {
                    return "0.00km/h";
                }
            }
            set
            {
                //if (!string.IsNullOrEmpty(value))
                //{
                //    value = value.Substring(0, value.IndexOf('.') + 3);
                //}
                _sLastSpeedOfFuel = value;
            }
        }
        #endregion

        /// <summary>
        /// 交通部油耗附加报文
        /// </summary>
        public string JTBExtendOilData { get; set; }

        /// <summary>
        /// 燃气终端附加报文
        /// </summary>
        public string GasConcentration { get; set; }

        /// <summary>
        /// 燃气车终端浓度描述
        /// </summary>
        public string GasChromaDesc { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 视频ip
        /// </summary>
        public string VideoServerIP { get; set; }

        /// <summary>
        /// 视频端口
        /// </summary>
        public int VideoServerPort { get; set; }

        /// <summary>
        /// 视频udp端口
        /// </summary>
        public int VideoServerUDPPort { get; set; }

        public string VideoCommunicateID { get; set; }

        public string DVRUserName { get; set; }

        public string DVRUserPwd { get; set; }

        public int DVRChannelNum { get; set; }

        public string DVRTypeCode { get; set; }

        private List<string> _listOilOfDeviceData = null;//new List<string>();

        /// <summary>
        /// 外设数据油耗
        /// </summary>
        public string OilOfDeviceData
        {
            get
            {
                if (_listOilOfDeviceData == null || _listOilOfDeviceData.Count <= 0)
                    return string.Empty;
                int iLength = _listOilOfDeviceData.Count;
                string sDescrip = string.Empty;
                for (int i = 0; i < iLength; i++)
                {
                    sDescrip += string.Format("油耗仪{0}:{1}L;", i + 1, _listOilOfDeviceData[i]);
                }
                return sDescrip;
            }
            set
            {
                string[] sOil = value.Split('|');   //  1,100|2,100
                if (sOil == null || sOil.Length <= 0)
                    return;
                if (_listOilOfDeviceData == null)
                    _listOilOfDeviceData = new List<string>();
                for (int i = 0; i < sOil.Length; i++)
                {
                    string[] sIdValue = sOil[i].Split(',');
                    if (sIdValue == null || sIdValue.Length <= 0)
                        continue;
                    int iId = 0;
                    if (!int.TryParse(sIdValue[0], out iId))
                        continue;
                    if (_listOilOfDeviceData.Count < iId)
                    {
                        for (int j = _listOilOfDeviceData.Count; j < iId; j++)
                        {
                            _listOilOfDeviceData.Add("未知");
                        }
                    }
                    _listOilOfDeviceData[iId - 1] = sIdValue[1];
                }
            }
        }

        private List<string> _listTemperatureOfDevieData = null;//new List<string>();

        /// <summary>
        /// 外设数据温度
        /// </summary>
        public string TemperatureOfDeviceData
        {
            get
            {
                if (_listTemperatureOfDevieData == null || _listTemperatureOfDevieData.Count <= 0)
                    return string.Empty;
                int iLength = _listTemperatureOfDevieData.Count;
                string sDescrip = string.Empty;
                for (int i = 0; i < iLength; i++)
                {
                    sDescrip += string.Format("温度仪{0}:{1}℃;", i + 1, _listTemperatureOfDevieData[i]);
                }
                return sDescrip;
            }
            set
            {
                string[] sOil = value.Split('|');   //  1,100|2,100
                if (sOil == null || sOil.Length <= 0)
                    return;
                if (_listTemperatureOfDevieData == null)
                    _listTemperatureOfDevieData = new List<string>();
                for (int i = 0; i < sOil.Length; i++)
                {
                    string[] sIdValue = sOil[i].Split(',');
                    if (sIdValue == null || sIdValue.Length <= 0)
                        continue;
                    int iId = 0;
                    if (!int.TryParse(sIdValue[0], out iId))
                        continue;
                    if (_listTemperatureOfDevieData.Count < iId)
                    {
                        for (int j = _listTemperatureOfDevieData.Count; j < iId; j++)
                        {
                            _listTemperatureOfDevieData.Add("未知");
                        }
                    }
                    _listTemperatureOfDevieData[iId - 1] = sIdValue[1];
                }
            }
        }

        private List<string> _listElectricOfDeviceData = null;
        /// <summary>
        /// 外设数据电量
        /// </summary>
        public string ElectricOfDeviceData
        {
            get
            {
                if (_listElectricOfDeviceData == null || _listElectricOfDeviceData.Count <= 0)
                    return string.Empty;
                string[] sValue = _listElectricOfDeviceData[0].Split('|');
                string sDescrip = string.Empty;
                string sAlarmName = string.Empty;
                int iAlarmType = 0;
                if (sValue.Length < 6)
                    return sDescrip;
                if (!string.IsNullOrEmpty(sValue[5]))
                    iAlarmType = int.Parse(sValue[5]);
                if ((iAlarmType & 1) == 1)
                    sAlarmName += "设备电量报警;";
                if ((iAlarmType & 2) == 2)
                    sAlarmName += "行车电量报警;";
                if ((iAlarmType & 4) == 4)
                    sAlarmName += "冷藏电量报警;";
                sDescrip = string.Format("设备电量:{0}%;行车电量:{1}%;冷藏电量:{2}%;{3}", sValue[0], sValue[1], sValue[2], sAlarmName);
                return sDescrip;
            }
            set
            {
                string[] sdata = value.Split(','); //1,99.9|99.9|0|0|0|0 目前只有一路
                if (_listElectricOfDeviceData == null)
                    _listElectricOfDeviceData = new List<string>();
                int iId = 0;
                if (int.TryParse(sdata[0], out iId))
                {
                    if (_listElectricOfDeviceData.Count < iId)
                    {
                        for (int j = _listElectricOfDeviceData.Count; j < iId; j++)
                        {
                            _listElectricOfDeviceData.Add("未知|未知|未知|未知|未知|0");
                        }
                    }
                    _listElectricOfDeviceData[iId - 1] = sdata[1];
                }
            }
        }

        private List<string> _listWeightOfDeviceData = null;
        /// <summary>
        /// 外设数据载货重量
        /// </summary>
        public string WeightOfDeviceData
        {
            get
            {
                if (_listWeightOfDeviceData == null || _listWeightOfDeviceData.Count <= 0)
                    return string.Empty;
                int iLength = _listWeightOfDeviceData.Count;
                string sDescrip = string.Empty;
                for (int i = 0; i < iLength; i++)
                {
                    string[] sValue = _listWeightOfDeviceData[i].Split('|');
                    string sWeightName = string.Empty;
                    if (sValue.Length < 4)
                        break;
                    if (sValue[0] == "未知")
                        continue;
                    if (!string.IsNullOrEmpty(sValue[0]))
                    {
                        if (sValue[0] == "0")
                            sWeightName = "空载";
                        else if (sValue[0] == "1")
                            sWeightName = "半载";
                        else if (sValue[0] == "2")
                            sWeightName = "满载";
                        else if (sValue[0] == "3")
                            sWeightName = "超载";
                        else if (sValue[0] == "4")
                            sWeightName = "装载";
                        else if (sValue[0] == "5")
                            sWeightName = "卸载";
                    }
                    sDescrip += string.Format("载重传感器{0}：状态:{1};载荷重量:{2}t;实载重量:{3}t;", i + 1, sWeightName,
                        (float.Parse(sValue[2]) * 0.1).ToString(), (float.Parse(sValue[3]) * 0.1).ToString()) + "\r\n";
                }
                return sDescrip;
            }
            set
            {
                string[] sdata = value.Split(','); //1,99.9|99.9|0|0
                if (_listWeightOfDeviceData == null)
                    _listWeightOfDeviceData = new List<string>();
                int iId = 0;
                if (int.TryParse(sdata[0], out iId))
                {
                    if (_listWeightOfDeviceData.Count < iId)
                    {
                        for (int j = _listWeightOfDeviceData.Count; j < iId; j++)
                        {
                            _listWeightOfDeviceData.Add("未知|未知|未知|未知");
                        }
                    }
                    _listWeightOfDeviceData[iId - 1] = sdata[1];
                }
            }
        }

        private List<string> _listTirePressureOfDeviceData = null;
        /// <summary>
        /// 外设数据胎压
        /// </summary>
        public string TirePressureOfDeviceData
        {
            get
            {
                if (_listTirePressureOfDeviceData == null || _listTirePressureOfDeviceData.Count <= 0)
                    return string.Empty;
                int iLength = _listTirePressureOfDeviceData.Count;
                string sDescrip = string.Empty;
                for (int i = 0; i < iLength; i++)
                {
                    string[] sValue = _listTirePressureOfDeviceData[i].Split('|');
                    if (sValue.Length < 4)
                        break;
                    if (sValue[0] == "未知")
                        continue;
                    string sAlarmName = string.Empty;
                    int iAlarmType = 0;
                    if (!string.IsNullOrEmpty(sValue[0]))
                        iAlarmType = int.Parse(sValue[0]);
                    if (iAlarmType == 0)
                    {
                        sAlarmName = "胎压正常;";
                    }
                    else
                    {
                        if ((iAlarmType & 1) == 0)
                            sAlarmName += "胎压值不正常;";
                        if ((iAlarmType & 2) == 2)
                            sAlarmName += "胎压过高;";
                        if ((iAlarmType & 4) == 4)
                            sAlarmName += "胎压过低;";
                        if ((iAlarmType & 8) == 8)
                            sAlarmName += "胎温过高;";
                        if ((iAlarmType & 16) == 16)
                            sAlarmName += "传感器异常;";
                        if ((iAlarmType & 32) == 32)
                            sAlarmName += "胎压不平衡;";
                        if ((iAlarmType & 64) == 64)
                            sAlarmName += "满漏气;";
                    }
                    sDescrip += string.Format("轮胎{0}：{1}胎压:{2}Kpa({5:f2}Bar);胎温:{3}℃;电量:{4}%;", (i + 1).ToString().PadLeft(2, '0'), sAlarmName, (float.Parse(sValue[1]) * 0.1).ToString("0.0"), ((float.Parse(sValue[2]) - 2731.5) * 0.1).ToString("0.0"), sValue[3], (float.Parse(sValue[1]) * 0.001)) + "\r\n";
                }
                return sDescrip;
            }
            set
            {
                string[] sdata = value.Split(','); //1,99.9|99.9|0|0
                if (_listTirePressureOfDeviceData == null)
                    _listTirePressureOfDeviceData = new List<string>();
                int iId = 0;
                if (int.TryParse(sdata[0], out iId))
                {
                    if (_listTirePressureOfDeviceData.Count < iId)
                    {
                        for (int j = _listTirePressureOfDeviceData.Count; j < iId; j++)
                        {
                            _listTirePressureOfDeviceData.Add("未知|未知|未知|未知");
                        }
                    }
                    _listTirePressureOfDeviceData[iId - 1] = sdata[1];
                }
            }
        }

        public string TravelCarInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 营运路线
        /// </summary>
        public string OperationRoute
        {
            get;
            set;
        }

        /// <summary>
        /// 营运开始地理位置
        /// </summary>
        public string OperateBeginPos
        {
            get;
            set;
        }

        /// <summary>
        /// 营运结束地理位置
        /// </summary>
        public string OperateEndPos
        {
            get;
            set;
        }

        /// <summary>
        /// 营运中间位置
        /// </summary>
        public string OperateCenterPos
        {
            get;
            set;
        }

        /// <summary>
        /// 电池百分比  0x50 表示  80%
        /// </summary>
        public string BatteryPercent
        {
            get;
            set;
        }

        /// <summary>
        /// 部标拓展报文
        /// </summary>
        public string AdditionData
        {
            get;
            set;
        }

        /// <summary>
        /// 区所
        /// </summary>
        public string UnitArea
        {
            get;
            set;
        }

        /// <summary>
        /// 运营商
        /// </summary>
        public string OperatorName
        {
            get;
            set;
        }

        public int TerminalTypeId
        {
            get;
            set;
        }
        /// <summary>
        /// 油量数据描述，显示解析后的最终油量信息，包括所有类型的油量数据，如天凯风林多路油量、部标标准油量、外设油量等
        /// </summary>
        public string OilDescription
        {
            get { return _sOilDescription; }
            set { _sOilDescription = value; }
        }

        /// <summary>
        /// TKFL油量信息
        /// </summary>
        //public FuelInfo FuelInfo
        //{
        //    get { return _fuelInfo; }
        //    set { _fuelInfo = value; }
        //}

        /// <summary>
        /// 设备安装时间
        /// </summary>
        public string EquipmentInstallTime
        {
            get;
            set;
        }

        /// <summary>
        /// 剩余电量
        /// </summary>
        public string ResidualElectricity
        {
            get;
            set;
        }
        /// <summary>
        /// 载货重量
        /// </summary>
        public string LoadWeight
        {
            get;
            set;
        }
        #endregion

        /// <summary>
        /// 业户名称
        /// </summary>
        public string CorpName
        {
            get;
            set;
        }

        public string VehicleSearchCode { get; set; }

        /// <summary>
        /// 车主姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 车主联系电话
        /// </summary>
        public string OwnerSimNum { get; set; }

        /// <summary>
        /// 上一次停车开始时间 为gpstime
        /// </summary>
        public DateTime LastParkTime { get; set; }

        /// <summary>
        /// 停车时长描述
        /// </summary>
        public string ParkTimeDescribe
        {
            get
            {
                //if (!IsTravel)//IsOnline && 
                //{
                //    if (LastParkTime.Year <= 2017)
                //        return "";
                //    else
                //        return StringHelper.GetDateTimeIntervalStr(LastParkTime, GpsTime);
                //}
                //else
                    return "";
            }
        }

        ////#region 构造函数

        /////// <summary>
        /////// 构造函数
        /////// </summary>
        /////// <param name="treeNodeEx">所属节点</param>
        ////public Vehicle()
        ////{
        ////    this.NodeType = 1;
        ////}

        ////#endregion

        #region 公共方法

        //public override void SetNodeShowText()
        //{
        //    base.SetNodeShowText();

        //    if (this.IsAlarm == true && _sCarStatus == OnLine)
        //    {
        //        _sCarStatus = Alarm;
        //    }
        //    if (this.ImageKey != _sCarStatus)
        //    {
        //        this.ImageKey = _sCarStatus;
        //        this.SelectedImageKey = _sCarStatus;
        //    }
        //}
        #endregion

        #region 私有方法
        /// <summary>
        /// 设置在线状态 
        /// </summary>
        /// <param name="newState"></param>
        private void SetVehicleOnline(string sStatus)
        {
            if (sStatus == _sCarStatus)
            {
                return;
            }
            //if (!VehicleIconHelper.IsOfflineImg(sStatus) && !VehicleIconHelper.IsOfflineImg(_sCarStatus))
            {
                _sCarStatus = sStatus;
                SetVehicleImg();
                return;
            }
            //_sCarStatus = sStatus;
            //SetVehicleImg();
            //int iAdd = 0;
            //// 离线 减1
            //if (sStatus == TopMonitor.BLL.BizHandler.VehicleListHelper.OffLineKey)
            //{
            //    //OnlineCnt = 0;
            //    iAdd = -1;
            //}
            //else// 在线 加1
            //{
            //    //OnlineCnt = 1;
            //    iAdd = 1;
            //}
            //Org org = this.Parent as Org;
            //org.OnlineCount += iAdd;
            //((Org)this.Parent).AddWaitRefreshOrgList(org);
            //while (org.Level >= 1)
            //{
            //    org = org.Parent as Org;
            //    org.OnlineCount += iAdd;
            //    ((Org)this.Parent).AddWaitRefreshOrgList(org);
            //}
            ////(this.TreeView as TreeViewEx).AddAreaNodeHashTable((TreeNodeEx)this.Parent);
        }

        private void UpdateOrgCount(bool value)
        {
            int iAdd = 0;
            if (IsFrozen)
                return;
            // 离线 减1
            if (_bIsOnline && !value)
            {
                //OnlineCnt = 0;
                iAdd = -1;
            }
            else if (!_bIsOnline && value)// 在线 加1
            {
                //OnlineCnt = 1;
                iAdd = 1;
            }
            else
            {
                _bIsOnline = value;
                return;
            }
            //Org org = this.Parent as Org;
            //org.OnlineCount += iAdd;
            //if (Checked)
            //{
            //    org.SelectOnlineCount += iAdd;
            //}
            //((Org)this.Parent).AddWaitRefreshOrgList(org);
            //while (org.Level >= 1)
            //{
            //    org = org.Parent as Org;
            //    org.OnlineCount += iAdd;
            //    if (Checked)
            //    {
            //        org.SelectOnlineCount += iAdd;
            //    }
            //    ((Org)this.Parent).AddWaitRefreshOrgList(org);
            //}
        }

        /// <summary>
        /// 设置车辆节点的显示图标
        /// </summary>
        private void SetVehicleImg()
        {
            try
            {
                if (this.Level > 0 && !this.Parent.IsExpanded)
                {
                    return;
                }
                if (this.ImageKey != _sCarStatus)
                {
                    this.ImageKey = _sCarStatus;
                    this.SelectedImageKey = _sCarStatus;
                }
            }
            catch { }
        }
        #region 设置节点显示文本
        /// <summary>
        /// 设置节点显示文本
        /// </summary>
        public override void SetNodeShow()
        {
            if (this.Level > 0 && !this.Parent.IsExpanded)
            {
                return;
            }
            //if (this.IsAlarm == true && _sCarStatus == TopMonitor.BLL.BizHandler.VehicleListHelper.OnLineKey)
            //{
            //    _sCarStatus = TopMonitor.BLL.BizHandler.VehicleListHelper.AlarmKey;
            //}
            if (this.ImageKey != _sCarStatus)
            {
                this.ImageKey = _sCarStatus;
                this.SelectedImageKey = _sCarStatus;
            }
        }
        #endregion
        #endregion

        #region public method
        public string GetTransportDesc()
        {
            //if (Variable.TransportDescOrder == null || Variable.TransportDescOrder.Length <= 0)
            //    return TransportStatus;
            //for (int i = 0; i < Variable.TransportDescOrder.Length; i++)
            //{
            //    if (Variable.TransportDescOrder[i] == "TransportStatus")
            //    {
            //        if (string.IsNullOrEmpty(TransportStatus))
            //            continue;
            //        return TransportStatus;
            //    }
            //    if (Variable.TransportDescOrder[i] == "RepairStatus")
            //    {
            //        if (string.IsNullOrEmpty(RepairStatus))
            //            continue;
            //        return RepairStatus;
            //    }
            //    if (Variable.TransportDescOrder[i] == "TransportStatusByTime")
            //    {
            //        if (string.IsNullOrEmpty(TransportStatusByTime))
            //            continue;
            //        return TransportStatusByTime;
            //    }
            //}
            return string.Empty;
        }

        public string GetOperatePosDesc()
        {
            ////if (string.IsNullOrEmpty(OperateBeginPos) && string.IsNullOrEmpty(OperateEndPos))
            ////    return string.Empty;
            ////return string.Format("【{0}-{1}】", OperateBeginPos, OperateEndPos);
            if (string.IsNullOrEmpty(OperationRoute))
                return string.Empty;
            string[] sArray = OperationRoute.Split('-');
            if (sArray == null || sArray.Length <= 0)
                return string.Empty;
            if (sArray.Length == 1)
                return string.Format("【{0}】", sArray[0]);
            else
                return string.Format("【{0}-{1}】", sArray[0], sArray[sArray.Length - 1]);
        }

        /// <summary>
        /// 是否为停止运营
        /// </summary>
        /// <returns></returns>
        //public bool IsStopOperate()
        //{
        //    return Variable.VehicleStopOperateText.Equals(TransportStatus);
        //}

        public bool IsExistsVideo()
        {
            return !string.IsNullOrEmpty(DVRTypeCode) && !"0".Equals(DVRTypeCode); //!string.IsNullOrEmpty(VideoServerIP) && VideoServerPort > 0 && !string.IsNullOrEmpty(VideoCommunicateID) && DVRChannelNum > 0;
        }

        public bool IsExistsJtbVideo()
        {
            //return !string.IsNullOrEmpty(VideoCommunicateID) && DVRChannelNum > 0 && !string.IsNullOrEmpty(DVRTypeCode);
            return IsJtbVideoType(); //&& DVRChannelNum > 0;
        }

        public bool IsJtbVideoType()
        {
            return "999".Equals(DVRTypeCode) || "809".Equals(DVRTypeCode);
        }
        public bool IsExistsJtb809Video()
        {
            return "809".Equals(DVRTypeCode);
        }
        #endregion

        public string OilBox1TypeId { get; set; }

        public string OilBox2TypeId { get; set; }

        public string OilBox3TypeId { get; set; }

        private void UpdateTravelCount(bool Value)
        {
            int iAdd = 0;
            if (_bIsTravel && !Value)
            {
                iAdd = -1;
            }
            else if (!_bIsTravel && Value)
            {
                iAdd = 1;
            }
            else
            {
                _bIsTravel = Value;
                return;
            }
            //Org org = this.Parent as Org;
            //org.ShowTravelCount += iAdd;
            //if (Checked)
            //{
            //    org.SelectShowTravelCount += iAdd;
            //}
            //while (org.Level >= 1)
            //{
            //    org = org.Parent as Org;
            //    org.ShowTravelCount += iAdd;
            //    if (Checked)
            //    {
            //        org.SelectShowTravelCount += iAdd;
            //    }
            //}
        }

        public string Remark { get; set; }


        public void AutoFrozenVehicle(bool bValue)
        {
            this._bIsAutoFrozen = bValue;
        }

        private void UpdateLastParkTime()
        {
            try
            {
                if (string.IsNullOrEmpty(GpsTime))
                    return;
                DateTime dtmValue = default(DateTime);
                if (DateTime.TryParse(GpsTime, out dtmValue))
                {
                    LastParkTime = dtmValue;
                }
            }
            catch (Exception )
            {
                //Variable.MyLogHelper.Error("Vehicle.UpdateLastParkTime", ex);
            }
        }

        /// <summary>
        /// 运营状态 正常 停运 维修；（用于车辆统计中只统计已勾选车辆）
        /// </summary>
        public string SelectState { get; set; }

        /// <summary>
        /// 是否安装视频 （用于车辆统计中只统计已勾选车辆）
        /// </summary>
        public bool SelectVehicleWithVideo { get; set; }

        ///// <summary>
        ///// 上次停车时间 
        ///// </summary>
        //public DateTime LastStopTime { get; set; }

        public string SearchCode { get; set; }

        #region 包车牌信息

        private string _sBookInfo = "";
        private string _sBookStartDay = "";
        private string _sBookEndDay = "";

        /// <summary>
        /// 运输企业
        /// </summary>
        private string _sBookCompany = "";
        public string BookCompany
        {
            get { return _sBookCompany; }
            set { _sBookCompany = value; }
        }

        /// <summary>
        /// 包车类别
        /// </summary>
        private string _sBookType = "";
        public string BookType
        {
            get { return _sBookType; }
            set { _sBookType = value; }
        }

        /// <summary>
        /// 起始地
        /// </summary>
        private string _sBookStartingPlace = "";
        public string BookStartingPlace
        {
            get { return _sBookStartingPlace; }
            set { _sBookStartingPlace = value; }
        }

        /// <summary>
        /// 终到地
        /// </summary>
        private string _sBookDestination = "";
        public string BookDestination
        {
            get { return _sBookDestination; }
            set { _sBookDestination = value; }
        }

        /// <summary>
        /// 主要途径地
        /// </summary>
        private string _sBookPathWay = "";
        public string BookPathWay
        {
            get { return _sBookPathWay; }
            set { _sBookPathWay = value; }
        }

        /// <summary>
        /// 行程开始日期
        /// </summary>
        public string BookStartDay
        {
            get
            {
                return _sBookStartDay;
            }
            set
            {
                DateTime sBookStartDay = DateTime.Now;
                if (DateTime.TryParse(value, out sBookStartDay))
                {
                    _sBookStartDay = sBookStartDay.ToString("MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                }
                else
                {

                    _sBookStartDay = "";
                }
            }
        }

        /// <summary>
        /// 行程结束日期
        /// </summary>
        public string BookEndDay
        {
            get { return _sBookEndDay; }
            set
            {
                DateTime sBookEndDay = DateTime.Now;
                if (DateTime.TryParse(value, out sBookEndDay))
                {
                    _sBookEndDay = DateTime.Parse(value).ToString("MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                }
                else
                {
                    _sBookEndDay = "";
                }
            }
        }


        public string BookInfo
        {
            get
            {
                _sBookInfo = string.Format("{0}{{{1}({2} {3}-{4})}}", BookCompany, BookPathWay, BookType, BookStartDay, BookEndDay);
                if (_sBookInfo == "{( -)}")
                {
                    return "";
                }
                return _sBookInfo;
            }
        }
        #endregion

        private string _sChanelNumInfo;

        public string ChanelNumInfo
        {
            get
            {
                return _sChanelNumInfo;
            }
            set
            {
                if (value != _sChanelNumInfo)
                {
                    CreateCameras(value);
                }
                _sChanelNumInfo = value;
            }
        }

        /// <summary>
        /// 创建摄像头
        /// </summary>
        /// <param name="sChanelNumInfo"></param>
        public void CreateCameras(string sChanelNumInfo)
        {
            try
            {
                int iCH = 0;
                var arrCameras = sChanelNumInfo.Split('|');
                if (arrCameras == null || arrCameras.Length <= 0)
                {
                    this.DVRChannelNum = 0;
                    return;
                }
                this.DVRChannelNum = arrCameras.Length;
                this.Nodes.Clear();

                foreach (var sCamera in arrCameras)
                {
                    var arrCameraInfo = sCamera.Split(',');
                    if (arrCameraInfo.Length != 2)
                    {
                        continue;
                    }
                    if (int.TryParse(arrCameraInfo[0], out iCH))
                    {
                        //Camera camera = new Camera();
                        //camera.ChannelNo = iCH;
                        //camera.IsPlay = false;
                        //camera.Text = arrCameraInfo[1];
                        ////设置通道图标
                        //ChannelIconHelper.SetChannelIcon(camera);
                        //this.Nodes.Add(camera);
                    }
                }
            }
            catch
            {
                this.DVRChannelNum = 0;
            }
        }

        /// <summary>
        /// 创建摄像头
        /// </summary>
        /// <param name="sChanelNumInfo"></param>
        public void CreateCameras(int iChannelNum)
        {
            if (iChannelNum < 0)
                iChannelNum = 0;
            this.DVRChannelNum = iChannelNum;
            this.Nodes.Clear();
            for (int i = 1; i <= iChannelNum; i++)
            {
                //Camera camera = new Camera();
                //camera.ChannelNo = i;
                //camera.IsPlay = false;
                //camera.Text = "通道" + i;
                ////设置通道图标
                //ChannelIconHelper.SetChannelIcon(camera);
                ////camera.ImageKey = camera.SelectedImageKey = "camare_gray";
                //this.Nodes.Add(camera);
            }
        }
    }
}
