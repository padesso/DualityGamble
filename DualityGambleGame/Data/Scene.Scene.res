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
          <item dataType="Struct" type="Duality.Components.VelocityTracker" id="1706013928">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="1181265938">
            <active dataType="Bool">true</active>
            <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
            <farZ dataType="Float">10000</farZ>
            <focusDist dataType="Float">1000</focusDist>
            <gameobj dataType="ObjectRef">3929846757</gameobj>
            <nearZ dataType="Float">50</nearZ>
            <priority dataType="Int">0</priority>
            <projection dataType="Enum" type="Duality.Drawing.ProjectionMode" name="Orthographic" value="0" />
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
    <item dataType="Struct" type="Duality.GameObject" id="2176392774">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2915082128">
        <_items dataType="Array" type="Duality.Component[]" id="3501846844" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="2233669992">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">2176392774</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">275</Y>
              <Z dataType="Float">0</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">275</Y>
              <Z dataType="Float">0</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.TextRenderer" id="3059330428">
            <active dataType="Bool">true</active>
            <blockAlign dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">49</B>
              <G dataType="Byte">49</G>
              <R dataType="Byte">49</R>
            </colorTint>
            <customMat />
            <gameobj dataType="ObjectRef">2176392774</gameobj>
            <iconMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]" />
            <offset dataType="Float">0</offset>
            <text dataType="Struct" type="Duality.Drawing.FormattedText" id="4594668">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="225750628">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText dataType="String">Debug text...</sourceText>
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </text>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="914592494" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="330568162">
            <item dataType="ObjectRef">1296828646</item>
            <item dataType="Type" id="4287452816" value="Duality.Components.Renderers.TextRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3538601098">
            <item dataType="ObjectRef">2233669992</item>
            <item dataType="ObjectRef">3059330428</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">2233669992</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="363978770">OUpwVf8D80GEKjw0nqKgXg==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">DebugText</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="540414734">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1423862680">
        <_items dataType="Array" type="Duality.Component[]" id="3716719660" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="597691952">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">540414734</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2009034014">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">540414734</gameobj>
            <offset dataType="Float">10</offset>
            <pixelGrid dataType="Bool">false</pixelGrid>
            <rect dataType="Struct" type="Duality.Rect">
              <H dataType="Float">1024</H>
              <W dataType="Float">1600</W>
              <X dataType="Float">-800</X>
              <Y dataType="Float">-512</Y>
            </rect>
            <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
            <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
              <contentPath dataType="String">Data\Background\bg_grasslands.Material.res</contentPath>
            </sharedMat>
            <spriteIndex dataType="Int">-1</spriteIndex>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2476505886" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="152745050">
            <item dataType="ObjectRef">1296828646</item>
            <item dataType="Type" id="666080256" value="Duality.Components.Renderers.SpriteRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3937530298">
            <item dataType="ObjectRef">597691952</item>
            <item dataType="ObjectRef">2009034014</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">597691952</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="721860698">I2iY4S2bZ0OQ7LzaTegGcw==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Background</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="4100170527">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1836048349">
        <_items dataType="Array" type="Duality.Component[]" id="3700540518" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="4157447745">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">4100170527</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="DualityGambleGame.Graphics.GameBoardRenderer" id="3636699007">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">4100170527</gameobj>
            <transform dataType="ObjectRef">4157447745</transform>
          </item>
        </_items>
        <_size dataType="Int">2</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="388918392" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="804554423">
            <item dataType="ObjectRef">1296828646</item>
            <item dataType="Type" id="2938553230" value="DualityGambleGame.Graphics.GameBoardRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="4014568256">
            <item dataType="ObjectRef">4157447745</item>
            <item dataType="ObjectRef">3636699007</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">4157447745</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="214371477">DGsX5Fudmk2RWUwfW2870A==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameBoardRenderer</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="381929272">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="390690782">
        <_items dataType="Array" type="Duality.Component[]" id="3468161296" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="439206490">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <gameobj dataType="ObjectRef">381929272</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
          </item>
          <item dataType="Struct" type="DualityGambleGame.Graphics.PlayerRenderer" id="4151407053">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">381929272</gameobj>
            <playerList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="49804697">
              <_items dataType="Array" type="Duality.GameObject[]" id="1202252878">
                <item dataType="Struct" type="Duality.GameObject" id="2929186314">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2908272398">
                    <_items dataType="Array" type="Duality.Component[]" id="144946640" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="2986463532">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">0</angle>
                        <angleAbs dataType="Float">0</angleAbs>
                        <gameobj dataType="ObjectRef">2929186314</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-43</X>
                          <Y dataType="Float">-211</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-43</X>
                          <Y dataType="Float">-211</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">1</scale>
                        <scaleAbs dataType="Float">1</scaleAbs>
                      </item>
                      <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="102838298">
                        <active dataType="Bool">true</active>
                        <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                          <A dataType="Byte">255</A>
                          <B dataType="Byte">255</B>
                          <G dataType="Byte">255</G>
                          <R dataType="Byte">255</R>
                        </colorTint>
                        <customMat />
                        <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                        <gameobj dataType="ObjectRef">2929186314</gameobj>
                        <offset dataType="Float">-10</offset>
                        <pixelGrid dataType="Bool">false</pixelGrid>
                        <rect dataType="Struct" type="Duality.Rect">
                          <H dataType="Float">92</H>
                          <W dataType="Float">66</W>
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                        </rect>
                        <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                        <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                          <contentPath dataType="String">Data\Players\alienPink.Material.res</contentPath>
                        </sharedMat>
                        <spriteIndex dataType="Int">-1</spriteIndex>
                        <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2509322570" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="932391628">
                        <item dataType="ObjectRef">1296828646</item>
                        <item dataType="ObjectRef">666080256</item>
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="1539864310">
                        <item dataType="ObjectRef">2986463532</item>
                        <item dataType="ObjectRef">102838298</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">2986463532</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="1876058328">SibcjzPs0UC4I8U0HrTWhw==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Disposed" value="3" />
                  <name dataType="String">Player1</name>
                  <parent />
                  <prefabLink />
                </item>
                <item dataType="Struct" type="Duality.GameObject" id="1186647633">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3240965601">
                    <_items dataType="Array" type="Duality.Component[]" id="3171877230" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="1243924851">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">0</angle>
                        <angleAbs dataType="Float">0</angleAbs>
                        <gameobj dataType="ObjectRef">1186647633</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-193</X>
                          <Y dataType="Float">-61</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-193</X>
                          <Y dataType="Float">-61</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">1</scale>
                        <scaleAbs dataType="Float">1</scaleAbs>
                      </item>
                      <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2655266913">
                        <active dataType="Bool">true</active>
                        <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                          <A dataType="Byte">255</A>
                          <B dataType="Byte">255</B>
                          <G dataType="Byte">255</G>
                          <R dataType="Byte">255</R>
                        </colorTint>
                        <customMat />
                        <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                        <gameobj dataType="ObjectRef">1186647633</gameobj>
                        <offset dataType="Float">-10</offset>
                        <pixelGrid dataType="Bool">false</pixelGrid>
                        <rect dataType="Struct" type="Duality.Rect">
                          <H dataType="Float">92</H>
                          <W dataType="Float">66</W>
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                        </rect>
                        <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                        <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                          <contentPath dataType="String">Data\Players\alienGreen.Material.res</contentPath>
                        </sharedMat>
                        <spriteIndex dataType="Int">-1</spriteIndex>
                        <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="516192288" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="4121088619">
                        <item dataType="ObjectRef">1296828646</item>
                        <item dataType="ObjectRef">666080256</item>
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="1695005896">
                        <item dataType="ObjectRef">1243924851</item>
                        <item dataType="ObjectRef">2655266913</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">1243924851</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="3066617697">GM4Zzj1nFkqtT51KH2PqtQ==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Disposed" value="3" />
                  <name dataType="String">Player2</name>
                  <parent />
                  <prefabLink />
                </item>
                <item dataType="Struct" type="Duality.GameObject" id="1053825586">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3422718998">
                    <_items dataType="Array" type="Duality.Component[]" id="2028197152" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="1111102804">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">0</angle>
                        <angleAbs dataType="Float">0</angleAbs>
                        <gameobj dataType="ObjectRef">1053825586</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">107</X>
                          <Y dataType="Float">-61</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">107</X>
                          <Y dataType="Float">-61</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">1</scale>
                        <scaleAbs dataType="Float">1</scaleAbs>
                      </item>
                      <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2522444866">
                        <active dataType="Bool">true</active>
                        <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                          <A dataType="Byte">255</A>
                          <B dataType="Byte">255</B>
                          <G dataType="Byte">255</G>
                          <R dataType="Byte">255</R>
                        </colorTint>
                        <customMat />
                        <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                        <gameobj dataType="ObjectRef">1053825586</gameobj>
                        <offset dataType="Float">-10</offset>
                        <pixelGrid dataType="Bool">false</pixelGrid>
                        <rect dataType="Struct" type="Duality.Rect">
                          <H dataType="Float">92</H>
                          <W dataType="Float">66</W>
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                        </rect>
                        <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                        <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                          <contentPath dataType="String">Data\Players\alienBeige.Material.res</contentPath>
                        </sharedMat>
                        <spriteIndex dataType="Int">-1</spriteIndex>
                        <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="834004954" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="3611676900">
                        <item dataType="ObjectRef">1296828646</item>
                        <item dataType="ObjectRef">666080256</item>
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="1841600022">
                        <item dataType="ObjectRef">1111102804</item>
                        <item dataType="ObjectRef">2522444866</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">1111102804</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="892559072">djVWGMPV8ESSQcB7SoZimQ==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Disposed" value="3" />
                  <name dataType="String">Player3</name>
                  <parent />
                  <prefabLink />
                </item>
                <item dataType="Struct" type="Duality.GameObject" id="112275356">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="650856584">
                    <_items dataType="Array" type="Duality.Component[]" id="214886252" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="169552574">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">0</angle>
                        <angleAbs dataType="Float">0</angleAbs>
                        <gameobj dataType="ObjectRef">112275356</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-43</X>
                          <Y dataType="Float">89</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-43</X>
                          <Y dataType="Float">89</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">1</scale>
                        <scaleAbs dataType="Float">1</scaleAbs>
                      </item>
                      <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="1580894636">
                        <active dataType="Bool">true</active>
                        <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                          <A dataType="Byte">255</A>
                          <B dataType="Byte">255</B>
                          <G dataType="Byte">255</G>
                          <R dataType="Byte">255</R>
                        </colorTint>
                        <customMat />
                        <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                        <gameobj dataType="ObjectRef">112275356</gameobj>
                        <offset dataType="Float">-10</offset>
                        <pixelGrid dataType="Bool">false</pixelGrid>
                        <rect dataType="Struct" type="Duality.Rect">
                          <H dataType="Float">92</H>
                          <W dataType="Float">66</W>
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                        </rect>
                        <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                        <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                          <contentPath dataType="String">Data\Players\alienYellow.Material.res</contentPath>
                        </sharedMat>
                        <spriteIndex dataType="Int">-1</spriteIndex>
                        <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="523609054" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="1389087050">
                        <item dataType="ObjectRef">1296828646</item>
                        <item dataType="ObjectRef">666080256</item>
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="3269294746">
                        <item dataType="ObjectRef">169552574</item>
                        <item dataType="ObjectRef">1580894636</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">169552574</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="1071654570">KwAE1jq7WkqvEdXlPoT0yg==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Disposed" value="3" />
                  <name dataType="String">Player4</name>
                  <parent />
                  <prefabLink />
                </item>
              </_items>
              <_size dataType="Int">4</_size>
            </playerList>
            <transform dataType="ObjectRef">439206490</transform>
          </item>
        </_items>
        <_size dataType="Int">2</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1016879370" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="917517308">
            <item dataType="ObjectRef">1296828646</item>
            <item dataType="Type" id="2500819780" value="DualityGambleGame.Graphics.PlayerRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="2302074774">
            <item dataType="ObjectRef">439206490</item>
            <item dataType="ObjectRef">4151407053</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">439206490</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="93512360">WB7uxWbFvUCXPuV3krNSMw==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">PlayerRenderer</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="2150344101">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1410069463">
        <_items dataType="Array" type="Duality.Component[]" id="1990462990" length="4">
          <item dataType="Struct" type="DualityGambleGame.Audio.GameAudioComponent" id="1262693602">
            <active dataType="Bool">true</active>
            <backgroundMusic dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data\Audio\Music\BackgroundMusic.Sound.Res</contentPath>
            </backgroundMusic>
            <backgroundMusicInstance />
            <gameobj dataType="ObjectRef">2150344101</gameobj>
          </item>
        </_items>
        <_size dataType="Int">1</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3626194880" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1196603997">
            <item dataType="Type" id="4198651750" value="DualityGambleGame.Audio.GameAudioComponent" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="2184277880">
            <item dataType="ObjectRef">1262693602</item>
          </values>
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3074553335">ePy1+tOZWES/69uFcjFkQQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameAudioComponent</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
