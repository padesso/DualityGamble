﻿<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="3929846757">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3202791831">
        <_items dataType="Array" type="Duality.Component[]" id="1256446222">
          <item dataType="Struct" type="Duality.Components.Transform" id="3987123975">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-500</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-500</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="1181265938">
            <active dataType="Bool">true</active>
            <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
            <farZ dataType="Float">10000</farZ>
            <focusDist dataType="Float">500</focusDist>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
            <nearZ dataType="Float">50</nearZ>
            <priority dataType="Int">0</priority>
            <projection dataType="Enum" type="Duality.Drawing.ProjectionMode" name="Perspective" value="1" />
            <renderSetup dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderSetup]]" />
            <renderTarget dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
            <shaderParameters dataType="Struct" type="Duality.Drawing.ShaderParameterCollection" id="2024019638" custom="true">
              <body />
            </shaderParameters>
            <targetRect dataType="Struct" type="Duality.Rect">
              <H dataType="Float">1</H>
              <W dataType="Float">1</W>
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
            </targetRect>
            <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
          </item>
          <item dataType="Struct" type="Duality.Components.VelocityTracker" id="1706013928">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.SoundListener" id="1667531988">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
          </item>
        </_items>
        <_size dataType="Int">4</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="262098624" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="33617693">
            <item dataType="Type" id="1296828646" value="Duality.Components.Transform" />
            <item dataType="Type" id="1437231418" value="Duality.Components.VelocityTracker" />
            <item dataType="Type" id="4262862438" value="Duality.Components.Camera" />
            <item dataType="Type" id="2770768058" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="238360312">
            <item dataType="ObjectRef">3987123975</item>
            <item dataType="ObjectRef">1706013928</item>
            <item dataType="ObjectRef">1181265938</item>
            <item dataType="ObjectRef">1667531988</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3987123975</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2058538423">hntZmbQX7EGwibFiELIYXA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="807436324">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4105446298">
        <_items dataType="Array" type="Duality.Component[]" id="410785664" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="864713542">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">807436324</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="DualityGambleGame.Gameplay.GameBoardComponent" id="2796311637">
            <active dataType="Bool">true</active>
            <debugMode dataType="Bool">true</debugMode>
            <gameobj dataType="ObjectRef">807436324</gameobj>
            <transform dataType="ObjectRef">864713542</transform>
          </item>
        </_items>
        <_size dataType="Int">2</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2631620410" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1527448032">
            <item dataType="ObjectRef">1296828646</item>
            <item dataType="Type" id="2997644252" value="DualityGambleGame.Gameplay.GameBoardComponent" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="1184945038">
            <item dataType="ObjectRef">864713542</item>
            <item dataType="ObjectRef">2796311637</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">864713542</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2942500092">q7JxB6GhdkuDtU+NYuHIUQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameBoardComponent</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->