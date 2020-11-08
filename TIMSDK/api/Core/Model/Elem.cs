using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using TIMSDK.Enum;

namespace TIMSDK.Model
{
    public class ElemConverter : CustomCreationConverter<Elem>
    {
        public override Elem Create(Type objectType)
        {
            return new Elem();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            var jObject = JObject.Load(reader);

            var elem_type = System.Enum.GetName(typeof(TIMElemType), jObject["elem_type"].ToObject<TIMElemType>());

            var target = new Elem();

            switch (elem_type)
            {
                case "kTIMElem_Text":
                    target = new TextElem();
                    break;
                case "kTIMElem_Image" :
                    target = new ImageElem();
                    break;
                case "kTIMElem_Sound":
                    target = new SoundElem();
                    break;
                case "kTIMElem_Custom":
                    target = new CustomElem();
                    break;
                case "kTIMElem_File":
                    target = new FileElem();
                    break;
                case "kTIMElem_GroupTips":
                    target = new GroupTipsElem();
                    break;
                case "kTIMElem_Face":
                    target = new FaceElem();
                    break;
                case "kTIMElem_Location":
                    target = new LocationElem();
                    break;
                case "kTIMElem_GroupReport":
                    break;
                case "kTIMElem_Video":
                    target = new VideoElem();
                    break;
                case "kTIMElem_FriendChange":
                    break;
                case "kTIMElem_ProfileChange":
                    break;
            }

            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }
    }

    /// <summary>
    /// 元素的类型
    /// </summary>
    [JsonConverter(typeof(ElemConverter))]
    public class Elem
    {
        /// <summary>
        /// 元素类型
        /// </summary>
        /// 
        [JsonProperty("elem_type")]
        public TIMElemType kTIMElemType { set; get; }
    }

    /// <summary>
    /// 文本元素。
    /// </summary>
    public class TextElem:Elem
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        /// 
        [JsonProperty("text_elem_content")]
        public string kTIMTextElemContent { set; get; }
    }

    /// <summary>
    /// 表情元素。
    /// </summary>
    public class FaceElem:Elem
    {
        /// <summary>
        /// 表情索引
        /// </summary>
        /// 
        [JsonProperty("face_elem_index")]
        public int kTIMFaceElemIndex { set; get; }
        /// <summary>
        /// 其他额外数据，可由用户自定义填写。若要传输二进制，麻烦先转码成字符串。JSON 只支持字符串
        /// </summary>
        /// 
        [JsonProperty("face_elem_buf")]
        public string kTIMFaceElemBuf { set; get; }
    }
    /// <summary>
    /// 位置元素
    /// </summary>
    public class LocationElem:Elem
    {
        /// <summary>
        /// 位置描述
        /// </summary>
        /// 
        [JsonProperty("location_elem_desc")]
        public string kTIMLocationElemDesc { set; get; }
        /// <summary>
        /// 经度
        /// </summary>
        /// 
        [JsonProperty("location_elem_longitude")]
        public double kTIMLocationElemLongitude { set; get; }
        /// <summary>
        /// 纬度
        /// </summary>
        /// 
        [JsonProperty("location_elem_latitude")]
        public double kTIMLocationElemlatitudes { set; get; }
    }

    public class ImageElem:Elem
    {
        /// <summary>
        /// 发送图片的路径
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_path")]
        public string kTIMImageElemOrigPath { set; get; }
        /// <summary>
        /// 发送图片的质量级别
        /// </summary>
        /// 
        [JsonProperty("image_elem_level")]
        public TIMImageLevel kTIMImageElemLevel { set; get; }
        /// <summary>
        /// 发送图片格式
        /// </summary>
        /// 
        [JsonProperty("image_elem_format")]
        public int kTIMImageElemFormat { set; get; }
        /// <summary>
        /// 原图的 UUID
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_id")]
        public string kTIMImageElemOrigId { set; get; }
        /// <summary>
        /// 原图的图片高度
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_pic_height")]
        public int kTIMImageElemOrigPicHeight { set; get; }
        /// <summary>
        /// 原图的图片宽度
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_pic_width")]
        public int kTIMImageElemOrigPicWidth { set; get; }
        /// <summary>
        /// 原图的图片大小
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_pic_size")]
        public int kTIMImageElemOrigPicSize { set; get; }
        /// <summary>
        /// 略缩图 UUID
        /// </summary>
        /// 
        [JsonProperty("image_elem_thumb_id")]
        public string kTIMImageElemThumbId { set; get; }
        /// <summary>
        /// 略缩图的图片高度
        /// </summary>
        /// 
        [JsonProperty("image_elem_thumb_pic_height")]
        public int kTIMImageElemThumbPicHeight { set; get; }
        /// <summary>
        /// 略缩图的图片宽度
        /// </summary>
        /// 
        [JsonProperty("image_elem_thumb_pic_width")]
        public int kTIMImageElemThumbPicWidth { set; get; }
        /// <summary>
        /// 略缩图的图片大小
        /// </summary>
        /// 
        [JsonProperty("image_elem_thumb_pic_size")]
        public int kTIMImageElemThumbPicSize { set; get; }
        /// <summary>
        /// 大图片 UUID
        /// </summary>
        /// 
        [JsonProperty("image_elem_large_id")]
        public string kTIMImageElemLargeId { set; get; }
        /// <summary>
        /// 大图片的图片高度
        /// </summary>
        /// 
        [JsonProperty("image_elem_large_pic_height")]
        public int kTIMImageElemLargePicHeight { set; get; }
        /// <summary>
        /// 大图片的图片宽度
        /// </summary>
        /// 
        [JsonProperty("image_elem_large_pic_width")]
        public int kTIMImageElemLargePicWidth { set; get; }
        /// <summary>
        /// 大图片的图片大小
        /// </summary>
        /// 
        [JsonProperty("image_elem_large_pic_size")]
        public int kTIMImageElemLargePicSize { set; get; }
        /// <summary>
        /// 原图 URL
        /// </summary>
        /// 
        [JsonProperty("image_elem_orig_url")]
        public string kTIMImageElemOrigUrl { set; get; }
        /// <summary>
        /// 略缩图 URL
        /// </summary>
        /// 
        [JsonProperty("image_elem_thumb_url")]
        public string kTIMImageElemThumbUrl { set; get; }
        /// <summary>
        /// 大图片 URL
        /// </summary>
        /// 
        [JsonProperty("image_elem_large_url")]
        public string kTIMImageElemLargeUrl { set; get; }
        /// <summary>
        /// 任务 ID
        /// </summary>
        /// 
        [JsonProperty("image_elem_task_id")]
        public int kTIMImageElemTaskId { set; get; }
    }

    public class SoundElem : Elem
    {
        /// <summary>
        /// 语音文件路径，需要开发者自己先保存语言然后指定路径
        /// </summary>
        /// 
        [JsonProperty("sound_elem_file_path")]
        public string kTIMSoundElemFilePath { set; get; }
        /// <summary>
        /// 语言数据文件大小，以秒为单位
        /// </summary>
        /// 
        [JsonProperty("sound_elem_file_size")]
        public int kTIMSoundElemFileSize { set; get; }
        /// <summary>
        /// 语音时长
        /// </summary>
        /// 
        [JsonProperty("sound_elem_file_time")]
        public int kTIMSoundElemFileTime { set; get; }
        /// <summary>
        /// 下载声音文件时的 ID
        /// </summary>
        /// 
        [JsonProperty("sound_elem_file_id")]
        public string kTIMSoundElemFileId { set; get; }
        /// <summary>
        /// 下载时用到的 businessID
        /// </summary>
        /// 
        [JsonProperty("sound_elem_business_id")]
        public int kTIMSoundElemBusinessId { set; get;}
        /// <summary>
        /// 是否需要申请下载地址（0：需要申请，1：到 cos 申请，2：不需要申请，直接拿 URL 下载）
        /// </summary>
        /// 
        [JsonProperty("sound_elem_download_flag")]
        public int kTIMSoundElemDownloadFlag { set; get; }
        /// <summary>
        /// 下载的 URL
        /// </summary>
        /// 
        [JsonProperty("sound_elem_url")]
        public string kTIMSoundElemUrl { set; get; }
        /// <summary>
        /// 任务 ID
        /// </summary>
        /// 
        [JsonProperty("sound_elem_task_id")]
        public int kTIMSoundElemTaskId { set; get; }
    }

    /// <summary>
    /// 自定义元素。
    /// </summary>
    public class CustomElem:Elem
    {
        /// <summary>
        /// 数据，支持二进制数据
        /// </summary>
        /// 
        [JsonProperty("custom_elem_data")]
        public string kTIMCustomElemData { set; get; }
        /// <summary>
        /// 自定义描述
        /// </summary>
        /// 
        [JsonProperty("custom_elem_desc")]
        public string kTIMCustomElemDesc { set; get; }
        /// <summary>
        /// 后台推送对应的 ext 字段
        /// </summary>
        /// 
        [JsonProperty("custom_elem_ext")]
        public string kTIMCustomElemExt { set; get; }
        /// <summary>
        /// 自定义声音
        /// </summary>
        /// 
        [JsonProperty("custom_elem_sound")]
        public string kTIMCustomElemSound { set; get; }
    }
    /// <summary>
    /// 文件元素
    /// </summary>
    public class FileElem:Elem
    {
        /// <summary>
        /// 文件所在路径（包含文件名）
        /// </summary>
        /// 
        [JsonProperty("file_elem_file_path")]
        public string kTIMFileElemFilePath { set; get; }
        /// <summary>
        /// 文件名，显示的名称。不设置该参数时，kTIMFileElemFileName 默认为 kTIMFileElemFilePath 指定的文件路径中的文件名
        /// </summary>
        /// 
        [JsonProperty("file_elem_file_name")]
        public string kTIMFileElemFileName { set; get; }
        /// <summary>
        /// 文件大小
        /// </summary>
        /// 
        [JsonProperty("file_elem_file_size")]
        public int kTIMFileElemFileSize { set; get; }
        /// <summary>
        /// 下载视频时的 UUID
        /// </summary>
        /// 
        [JsonProperty("file_elem_file_id")]
        public string kTIMFileElemFileId { set; get; }
        /// <summary>
        /// 下载时用到的 businessID
        /// </summary>
        /// 
        [JsonProperty("file_elem_business_id")]
        public int kTIMFileElemBusinessId { set; get; }
        /// <summary>
        /// 文件下载 flag
        /// </summary>
        /// 
        [JsonProperty("file_elem_download_flag")]
        public int kTIMFileElemDownloadFlag { set; get; }
        /// <summary>
        /// 文件下载的 URL
        /// </summary>
        /// 
        [JsonProperty("file_elem_url")]
        public string kTIMFileElemUrl { set; get; }
        /// <summary>
        /// 任务 ID
        /// </summary>
        /// 
        [JsonProperty("file_elem_task_id")]
        public int kTIMFileElemTaskId { set; get; }
    }
    /// <summary>
    /// 视频元素。
    /// </summary>
    public class VideoElem:Elem
    {
        /// <summary>
        /// 视频文件类型，发送消息时进行设置
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_type")]
        public string kTIMVideoElemVideoType { set; get; }
        /// <summary>
        /// 视频文件大小
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_size")]
        public uint kTIMVideoElemVideoSize { set; get; }
        /// <summary>
        /// 视频时长，发送消息时进行设置
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_duration")]
        public uint kTIMVideoElemVideoDuration { set; get; }
        /// <summary>
        /// 适配文件路径
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_path")]
        public string kTIMVideoElemVideoPath { set; get; }
        /// <summary>
        /// 下载视频时的 UUID
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_id")]
        public string kTIMVideoElemVideoId { set; get; }
        /// <summary>
        /// 下载时用到的 businessID
        /// </summary>
        /// 
        [JsonProperty("video_elem_business_id")]
        public int kTIMVideoElemBusinessId { set; get; }
        /// <summary>
        /// 视频文件下载 flag
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_download_flag")]
        public int kTIMVideoElemVideoDownloadFlag { set; get; }
        /// <summary>
        /// 视频文件下载的 URL
        /// </summary>
        /// 
        [JsonProperty("video_elem_video_url")]
        public string kTIMVideoElemVideoUrl { set; get; }
        /// <summary>
        /// 截图文件类型，发送消息时进行设置
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_type")]
        public string kTIMVideoElemImageType { set; get; }
        /// <summary>
        /// 截图文件大小
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_size")]
        public uint kTIMVideoElemImageSize { set; get; }
        /// <summary>
        /// 截图高度，发送消息时进行设置
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_width")]
        public uint kTIMVideoElemImageWidth { set; get; }
        /// <summary>
        /// 截图宽度，发送消息时进行设置
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_height")]
        public uint kTIMVideoElemImageHeight { set; get; }
        /// <summary>
        /// 保存截图的路径
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_path")]
        public string kTIMVideoElemImagePath { set; get; }
        /// <summary>
        /// 下载视频截图时的 ID
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_id")]
        public string kTIMVideoElemImageId { set; get; }
        /// <summary>
        /// 截图文件下载 flag
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_download_flag")]
        public int kTIMVideoElemImageDownloadFlag { set; get; }
        /// <summary>
        /// 截图文件下载的 URL
        /// </summary>
        /// 
        [JsonProperty("video_elem_image_url")]
        public string kTIMVideoElemImageUrl { set; get; }
        /// <summary>
        /// 任务 ID
        /// </summary>
        /// 
        [JsonProperty("video_elem_task_id")]
        public uint kTIMVideoElemTaskId { set; get; }

    }


    /// <summary>
    /// 群组系统消息元素（针对所有群成员)
    /// </summary>
    public class GroupTipsElem : Elem
    {
        /// <summary>
        /// 只读, 群消息类型
        /// </summary>
        [JsonProperty("group_tips_elem_tip_type")]
        public TIMGroupTipType kTIMGroupTipsElemTipType { set; get; }
        /// <summary>
        ///  操作者ID
        /// </summary>
        [JsonProperty("group_tips_elem_op_user")]
        public string kTIMGroupTipsElemOpUser { set; get; }
        /// <summary>
        /// 群组名称
        /// </summary>
        [JsonProperty("group_tips_elem_group_name")]
        public string kTIMGroupTipsElemGroupName { set; get; }
        /// <summary>
        /// 群组ID
        /// </summary>
        [JsonProperty("group_tips_elem_group_id")]
        public string kTIMGroupTipsElemGroupId { set; get; }
        /// <summary>
        /// 群消息时间
        /// </summary>
        [JsonProperty("group_tips_elem_time")]
        public uint kTIMGroupTipsElemTime { set; get; }
        /// <summary>
        /// 只读, 被操作的帐号列表
        /// </summary>
        [JsonProperty("group_tips_elem_user_array")]
        public List<string> kTIMGroupTipsElemUserArray { set; get; }
        /// <summary>
        /// 群资料变更信息列表,仅当 tips_type 值为 kTIMGroupTip_GroupInfoChange 时有效
        /// </summary>
        [JsonProperty("group_tips_elem_group_change_info_array")]
        public List<GroupTipGroupChangeInfo> kTIMGroupTipsElemGroupChangeInfoArray { set; get; }
        /// <summary>
        /// 群成员变更信息列表,仅当 tips_type 值为 kTIMGroupTip_MemberInfoChange 时有效
        /// </summary>
        [JsonProperty("group_tips_elem_member_change_info_array")]
        public List<GroupTipMemberChangeInfo> kTIMGroupTipsElemMemberChangeInfoArray { set; get; }
        /// <summary>
        /// 只读, 操作者个人资料
        /// </summary>
        [JsonProperty("group_tips_elem_op_user_info")]
        public UserProfile kTIMGroupTipsElemOpUserInfo { set; get; }
        /// <summary>
        /// 只读, 群成员信息
        /// </summary>
        [JsonProperty("group_tips_elem_op_group_memberinfo")]
        public GroupMemberInfo kTIMGroupTipsElemOpGroupMemberInfo { set; get; }
        /// <summary>
        /// 只读, 被操作者列表资料
        /// </summary>
        [JsonProperty("group_tips_elem_changed_user_info_array")]
        public List<UserProfile> kTIMGroupTipsElemChangedUserInfoArray { set; get; }
        /// <summary>
        ///  只读, 群成员信息列表
        /// </summary>
        [JsonProperty("group_tips_elem_changed_group_memberinfo_array")]
        public List<GroupMemberInfo> kTIMGroupTipsElemChangedGroupMemberInfoArray { set; get; }
        /// <summary>
        /// 当前群成员数,只有当事件消息类型为 kTIMGroupTip_Invite 、 kTIMGroupTip_Quit 、 kTIMGroupTip_Kick 时有效
        /// </summary>
        [JsonProperty("group_tips_elem_member_num")]
        public uint kTIMGroupTipsElemMemberNum { set; get; }
        /// <summary>
        /// 只读, 操作方平台信息
        /// </summary>
        [JsonProperty("group_tips_elem_platform")]
        public string kTIMGroupTipsElemPlatform { set; get; }
    }
}
