﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace directry
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace directry.directry_WindowsPhone_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[14];
            _typeNameTable[0] = "Windows.UI.Color";
            _typeNameTable[1] = "System.ValueType";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "Byte";
            _typeNameTable[4] = "directry.Views.DirectoryView";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[7] = "directry.Views.InstitutionProfileView";
            _typeNameTable[8] = "directry.Views.Login";
            _typeNameTable[9] = "directry.ViewModels.UserDetailViewModel";
            _typeNameTable[10] = "directry.Views.PasswordResetView";
            _typeNameTable[11] = "directry.Views.PersonProfileView";
            _typeNameTable[12] = "directry.Views.RequestPasswordResetCodeView";
            _typeNameTable[13] = "directry.Views.Signup";

            _typeTable = new global::System.Type[14];
            _typeTable[0] = typeof(global::Windows.UI.Color);
            _typeTable[1] = typeof(global::System.ValueType);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::System.Byte);
            _typeTable[4] = typeof(global::directry.Views.DirectoryView);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[7] = typeof(global::directry.Views.InstitutionProfileView);
            _typeTable[8] = typeof(global::directry.Views.Login);
            _typeTable[9] = typeof(global::directry.ViewModels.UserDetailViewModel);
            _typeTable[10] = typeof(global::directry.Views.PasswordResetView);
            _typeTable[11] = typeof(global::directry.Views.PersonProfileView);
            _typeTable[12] = typeof(global::directry.Views.RequestPasswordResetCodeView);
            _typeTable[13] = typeof(global::directry.Views.Signup);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_4_DirectoryView() { return new global::directry.Views.DirectoryView(); }
        private object Activate_7_InstitutionProfileView() { return new global::directry.Views.InstitutionProfileView(); }
        private object Activate_8_Login() { return new global::directry.Views.Login(); }
        private object Activate_9_UserDetailViewModel() { return new global::directry.ViewModels.UserDetailViewModel(); }
        private object Activate_10_PasswordResetView() { return new global::directry.Views.PasswordResetView(); }
        private object Activate_11_PersonProfileView() { return new global::directry.Views.PersonProfileView(); }
        private object Activate_12_RequestPasswordResetCodeView() { return new global::directry.Views.RequestPasswordResetCodeView(); }
        private object Activate_13_Signup() { return new global::directry.Views.Signup(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::directry.directry_WindowsPhone_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Windows.UI.Color
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                userType.AddMemberName("B");
                userType.AddMemberName("G");
                userType.AddMemberName("R");
                xamlType = userType;
                break;

            case 1:   //  System.ValueType
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 2:   //  Object
                xamlType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Byte
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  directry.Views.DirectoryView
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_DirectoryView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  directry.Views.InstitutionProfileView
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_InstitutionProfileView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  directry.Views.Login
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_Login;
                userType.AddMemberName("UserDetailVM");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  directry.ViewModels.UserDetailViewModel
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  directry.Views.PasswordResetView
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_PasswordResetView;
                userType.AddMemberName("UserDetailVM");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  directry.Views.PersonProfileView
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_PersonProfileView;
                userType.AddMemberName("UserDetailVM");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  directry.Views.RequestPasswordResetCodeView
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_RequestPasswordResetCodeView;
                userType.AddMemberName("UserDetailVM");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  directry.Views.Signup
                userType = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Signup;
                userType.AddMemberName("UserDetailVM");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_0_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_1_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_1_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_2_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_2_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_3_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_3_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }
        private object get_4_Login_UserDetailVM(object instance)
        {
            var that = (global::directry.Views.Login)instance;
            return that.UserDetailVM;
        }
        private object get_5_PasswordResetView_UserDetailVM(object instance)
        {
            var that = (global::directry.Views.PasswordResetView)instance;
            return that.UserDetailVM;
        }
        private object get_6_PersonProfileView_UserDetailVM(object instance)
        {
            var that = (global::directry.Views.PersonProfileView)instance;
            return that.UserDetailVM;
        }
        private object get_7_RequestPasswordResetCodeView_UserDetailVM(object instance)
        {
            var that = (global::directry.Views.RequestPasswordResetCodeView)instance;
            return that.UserDetailVM;
        }
        private object get_8_Signup_UserDetailVM(object instance)
        {
            var that = (global::directry.Views.Signup)instance;
            return that.UserDetailVM;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember xamlMember = null;
            global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Windows.UI.Color.A":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_0_Color_A;
                xamlMember.Setter = set_0_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_1_Color_B;
                xamlMember.Setter = set_1_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_2_Color_G;
                xamlMember.Setter = set_2_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_3_Color_R;
                xamlMember.Setter = set_3_Color_R;
                break;
            case "directry.Views.Login.UserDetailVM":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("directry.Views.Login");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "UserDetailVM", "directry.ViewModels.UserDetailViewModel");
                xamlMember.Getter = get_4_Login_UserDetailVM;
                xamlMember.SetIsReadOnly();
                break;
            case "directry.Views.PasswordResetView.UserDetailVM":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("directry.Views.PasswordResetView");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "UserDetailVM", "directry.ViewModels.UserDetailViewModel");
                xamlMember.Getter = get_5_PasswordResetView_UserDetailVM;
                xamlMember.SetIsReadOnly();
                break;
            case "directry.Views.PersonProfileView.UserDetailVM":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("directry.Views.PersonProfileView");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "UserDetailVM", "directry.ViewModels.UserDetailViewModel");
                xamlMember.Getter = get_6_PersonProfileView_UserDetailVM;
                xamlMember.SetIsReadOnly();
                break;
            case "directry.Views.RequestPasswordResetCodeView.UserDetailVM":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("directry.Views.RequestPasswordResetCodeView");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "UserDetailVM", "directry.ViewModels.UserDetailViewModel");
                xamlMember.Getter = get_7_RequestPasswordResetCodeView_UserDetailVM;
                xamlMember.SetIsReadOnly();
                break;
            case "directry.Views.Signup.UserDetailVM":
                userType = (global::directry.directry_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("directry.Views.Signup");
                xamlMember = new global::directry.directry_WindowsPhone_XamlTypeInfo.XamlMember(this, "UserDetailVM", "directry.ViewModels.UserDetailViewModel");
                xamlMember.Getter = get_8_Signup_UserDetailVM;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::directry.directry_WindowsPhone_XamlTypeInfo.XamlSystemBaseType
    {
        global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::directry.directry_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

