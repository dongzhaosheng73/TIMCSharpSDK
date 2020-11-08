using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 用户资料
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// 用户 ID
        /// </summary>
        /// 
        [JsonProperty("user_profile_identifier")]
        public string kTIMUserProfileIdentifier { set; get; }
        /// <summary>
        /// 用户的昵称
        /// </summary>
        /// 
        [JsonProperty("user_profile_nick_name")]
        public string kTIMUserProfileNickName { set; get; }
        /// <summary>
        /// 性别
        /// </summary>
        /// 
        [JsonProperty("user_profile_gender")]
        public TIMGenderType kTIMUserProfileGender { set; get; }
        /// <summary>
        /// 用户头像 URL
        /// </summary>
        /// 
        [JsonProperty("user_profile_face_url")]
        public string kTIMUserProfileFaceUrl { set; get; }
        /// <summary>
        /// 用户个人签名
        /// </summary>
        /// 
        [JsonProperty("user_profile_self_signature")]
        public string kTIMUserProfileSelfSignature { set; get; }
        /// <summary>
        /// 用户加好友的选项
        /// </summary>
        /// 
        [JsonProperty("user_profile_add_permission")]
        public TIMProfileAddPermission kTIMUserProfileAddPermission { set; get; }
        /// <summary>
        /// 用户位置信息
        /// </summary>
        /// 
        [JsonProperty("user_profile_location")]
        public string kTIMUserProfileLocation { set; get; }
        /// <summary>
        /// 语言
        /// </summary>
        /// 
        [JsonProperty("user_profile_language")]
        public uint kTIMUserProfileLanguage { set; get; }
        /// <summary>
        /// 生日
        /// </summary>
        /// 
        [JsonProperty("user_profile_birthday")]
        public uint kTIMUserProfileBirthDay { set; get; }
        /// <summary>
        /// 等级
        /// </summary>
        /// 
        [JsonProperty("user_profile_level")]
        public uint kTIMUserProfileLevel { set; get; }
        /// <summary>
        /// 角色
        /// </summary>
        /// 
        [JsonProperty("user_profile_role")]
        public uint kTIMUserProfileRole { set; get; }
        /// <summary>
        /// 自定义资料
        /// </summary>
        /// 
        [JsonProperty("user_profile_custom_string_array")]
        public List<GroupMemberInfoCustemString> kTIMUserProfileCustomStringArray { set; get; }
    }
}
