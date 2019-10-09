﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace InkRecognizerTest
{

 class TestUtils
    {
        public static string GetSimpleJsonForWriting()
        {
            var writingJson = @"{
              ""recognitionUnits"": [
                {
                  ""alternates"": [
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""hoy""
                    },
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""ney""
                    },
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""heif""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 33.8,
                    ""topX"": 37.9,
                    ""topY"": 16.7,
                    ""width"": 34.8
                  },
                  ""category"": ""inkWord"",
                  ""class"": ""leaf"",
                  ""id"": 4,
                  ""parentId"": 3,
                  ""recognizedText"": ""hey"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 40.1,
                      ""y"": 12.8
                    },
                    {
                      ""x"": 77.5,
                      ""y"": 33.4
                    },
                    {
                      ""x"": 66.8,
                      ""y"": 53.6
                    },
                    {
                      ""x"": 29.2,
                      ""y"": 32.4
                    }
                  ],
                  ""strokeIds"": [
                    95,
                    96,
                    97
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""hoy""
                    },
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""ney""
                    },
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""heif""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 33.8,
                    ""topX"": 37.9,
                    ""topY"": 16.7,
                    ""width"": 34.8
                  },
                  ""category"": ""line"",
                  ""childIds"": [
                    4
                  ],
                  ""class"": ""container"",
                  ""id"": 3,
                  ""parentId"": 2,
                  ""recognizedText"": ""hey"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 40.1,
                      ""y"": 12.8
                    },
                    {
                      ""x"": 77.5,
                      ""y"": 33.4
                    },
                    {
                      ""x"": 66.8,
                      ""y"": 53.6
                    },
                    {
                      ""x"": 29.2,
                      ""y"": 32.4
                    }
                  ],
                  ""strokeIds"": [
                    95,
                    96,
                    97
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 33.8,
                    ""topX"": 37.9,
                    ""topY"": 16.7,
                    ""width"": 34.8
                  },
                  ""category"": ""paragraph"",
                  ""childIds"": [
                    3
                  ],
                  ""class"": ""container"",
                  ""id"": 2,
                  ""parentId"": 1,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 40.1,
                      ""y"": 12.8
                    },
                    {
                      ""x"": 77.5,
                      ""y"": 33.4
                    },
                    {
                      ""x"": 66.8,
                      ""y"": 53.6
                    },
                    {
                      ""x"": 29.2,
                      ""y"": 32.4
                    }
                  ],
                  ""strokeIds"": [
                    95,
                    96,
                    97
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 33.8,
                    ""topX"": 37.9,
                    ""topY"": 16.7,
                    ""width"": 34.8
                  },
                  ""category"": ""writingRegion"",
                  ""childIds"": [
                    2
                  ],
                  ""class"": ""container"",
                  ""id"": 1,
                  ""parentId"": 0,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 40.1,
                      ""y"": 12.8
                    },
                    {
                      ""x"": 77.5,
                      ""y"": 33.4
                    },
                    {
                      ""x"": 66.8,
                      ""y"": 53.6
                    },
                    {
                      ""x"": 29.2,
                      ""y"": 32.4
                    }
                  ],
                  ""strokeIds"": [
                    95,
                    96,
                    97
                  ]
                },
                {
                    ""boundingRectangle"": {
                    ""height"": 33.8,
                    ""topX"": 37.9,
                    ""topY"": 16.7,
                    ""width"": 34.8
                    },
                    ""category"": ""root"",
                    ""childIds"": [1],
                    ""class"": ""container"",
                    ""id"": 0,
                    ""parentId"": 4294967295,
                    ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 40.1,
                      ""y"": 12.8
                    },
                    {
                      ""x"": 77.5,
                      ""y"": 33.4
                    },
                    {
                      ""x"": 66.8,
                      ""y"": 53.6
                    },
                    {
                      ""x"": 29.2,
                      ""y"": 32.4
                    }],
                    ""strokeIds"": [95, 96, 97]
                }
              ]
            }";
            return writingJson;
        }

        public static string GetJsonForWritingWithBullet()
        {
            var writingJsonWithBullet = @"{
              ""recognitionUnits"": [
                {
                  ""alternates"": [
                    {
                      ""category"": ""inkBullet"",
                      ""recognizedString"": ""O""
                    },
                    {
                      ""category"": ""inkBullet"",
                      ""recognizedString"": ""o""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 4.6,
                    ""topX"": 26.6,
                    ""topY"": 17.2,
                    ""width"": 4.6
                  },
                  ""category"": ""inkBullet"",
                  ""class"": ""leaf"",
                  ""id"": 5,
                  ""parentId"": 4,
                  ""recognizedText"": ""."",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 26.9,
                      ""y"": 16.5
                    },
                    {
                      ""x"": 31.6,
                      ""y"": 17.2
                    },
                    {
                      ""x"": 30.8,
                      ""y"": 22.1
                    },
                    {
                      ""x"": 26.1,
                      ""y"": 21.3
                    }
                  ],
                  ""strokeIds"": [
                    123
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""trey""
                    },
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""hoy""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 23.2,
                    ""topX"": 36.9,
                    ""topY"": 8.7,
                    ""width"": 33.5
                  },
                  ""category"": ""inkWord"",
                  ""class"": ""leaf"",
                  ""id"": 6,
                  ""parentId"": 4,
                  ""recognizedText"": ""hey"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 36.9,
                      ""y"": 8.7
                    },
                    {
                      ""x"": 71.8,
                      ""y"": 14.5
                    },
                    {
                      ""x"": 68.7,
                      ""y"": 33.6
                    },
                    {
                      ""x"": 33.8,
                      ""y"": 27.2
                    }
                  ],
                  ""strokeIds"": [
                    124
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""trey""
                    },
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""hoy""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 23.2,
                    ""topX"": 26.6,
                    ""topY"": 8.7,
                    ""width"": 43.9
                  },
                  ""category"": ""line"",
                  ""childIds"": [
                    5,
                    6
                  ],
                  ""class"": ""container"",
                  ""id"": 4,
                  ""parentId"": 2,
                  ""recognizedText"": ""hey"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 28.5,
                      ""y"": 7.3
                    },
                    {
                      ""x"": 71.8,
                      ""y"": 14.5
                    },
                    {
                      ""x"": 68.7,
                      ""y"": 33.6
                    },
                    {
                      ""x"": 25.4,
                      ""y"": 25.8
                    }
                  ],
                  ""strokeIds"": [
                    124,
                    123
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 23.2,
                    ""topX"": 26.6,
                    ""topY"": 8.7,
                    ""width"": 43.9
                  },
                  ""category"": ""paragraph"",
                  ""childIds"": [
                    4
                  ],
                  ""class"": ""container"",
                  ""id"": 2,
                  ""parentId"": 1,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 28.5,
                      ""y"": 7.3
                    },
                    {
                      ""x"": 71.8,
                      ""y"": 14.5
                    },
                    {
                      ""x"": 68.7,
                      ""y"": 33.6
                    },
                    {
                      ""x"": 25.4,
                      ""y"": 25.8
                    }
                  ],
                  ""strokeIds"": [
                    123,
                    124
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""inkBullet"",
                      ""recognizedString"": ""O""
                    },
                    {
                      ""category"": ""inkBullet"",
                      ""recognizedString"": ""o""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 4.4,
                    ""topX"": 27.6,
                    ""topY"": 41.2,
                    ""width"": 6.4
                  },
                  ""category"": ""inkBullet"",
                  ""class"": ""leaf"",
                  ""id"": 9,
                  ""parentId"": 8,
                  ""recognizedText"": ""."",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 27.6,
                      ""y"": 41.2
                    },
                    {
                      ""x"": 34.1,
                      ""y"": 41.3
                    },
                    {
                      ""x"": 34.8,
                      ""y"": 45.7
                    },
                    {
                      ""x"": 27.5,
                      ""y"": 45.6
                    }
                  ],
                  ""strokeIds"": [
                    125
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""halo""
                    },
                    {
                      ""category"": ""inkWord"",
                      ""recognizedString"": ""hollo""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 15.2,
                    ""topX"": 41.5,
                    ""topY"": 34.4,
                    ""width"": 37.1
                  },
                  ""category"": ""inkWord"",
                  ""class"": ""leaf"",
                  ""id"": 10,
                  ""parentId"": 8,
                  ""recognizedText"": ""hello"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 41.5,
                      ""y"": 34.4
                    },
                    {
                      ""x"": 78.9,
                      ""y"": 34.7
                    },
                    {
                      ""x"": 78.6,
                      ""y"": 49.4
                    },
                    {
                      ""x"": 41.2,
                      ""y"": 48.7
                    }
                  ],
                  ""strokeIds"": [
                    126
                  ]
                },
                {
                  ""alternates"": [
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""ohello""
                    },
                    {
                      ""category"": ""line"",
                      ""recognizedString"": ""W hello""
                    }
                  ],
                  ""boundingRectangle"": {
                    ""height"": 15.2,
                    ""topX"": 27.6,
                    ""topY"": 34.4,
                    ""width"": 51.1
                  },
                  ""category"": ""line"",
                  ""childIds"": [
                    9,
                    10
                  ],
                  ""class"": ""container"",
                  ""id"": 8,
                  ""parentId"": 7,
                  ""recognizedText"": ""hello"",
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 27.7,
                      ""y"": 33.7
                    },
                    {
                      ""x"": 78.9,
                      ""y"": 34.7
                    },
                    {
                      ""x"": 78.6,
                      ""y"": 49.4
                    },
                    {
                      ""x"": 27.5,
                      ""y"": 48.5
                    }
                  ],
                  ""strokeIds"": [
                    125,
                    126
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 15.2,
                    ""topX"": 27.6,
                    ""topY"": 34.4,
                    ""width"": 51.1
                  },
                  ""category"": ""paragraph"",
                  ""childIds"": [
                    8
                  ],
                  ""class"": ""container"",
                  ""id"": 7,
                  ""parentId"": 1,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 27.7,
                      ""y"": 33.7
                    },
                    {
                      ""x"": 78.9,
                      ""y"": 34.7
                    },
                    {
                      ""x"": 78.6,
                      ""y"": 49.4
                    },
                    {
                      ""x"": 27.5,
                      ""y"": 48.5
                    }
                  ],
                  ""strokeIds"": [
                    125,
                    126
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 40.5,
                    ""topX"": 26.6,
                    ""topY"": 8.7,
                    ""width"": 52.1
                  },
                  ""category"": ""writingRegion"",
                  ""childIds"": [
                    2,
                    7
                  ],
                  ""class"": ""container"",
                  ""id"": 1,
                  ""parentId"": 0,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 26.7,
                      ""y"": 8.5
                    },
                    {
                      ""x"": 79.3,
                      ""y"": 9.5
                    },
                    {
                      ""x"": 78.6,
                      ""y"": 49.4
                    },
                    {
                      ""x"": 26.4,
                      ""y"": 48.4
                    }
                  ],
                  ""strokeIds"": [
                    123,
                    124,
                    125,
                    126
                  ]
                },
                {
                  ""boundingRectangle"": {
                    ""height"": 40.5,
                    ""topX"": 26.6,
                    ""topY"": 8.7,
                    ""width"": 52.1
                  },
                  ""category"": ""root"",
                  ""childIds"": [
                    1
                  ],
                  ""class"": ""container"",
                  ""id"": 0,
                  ""parentId"": 4294967295,
                  ""rotatedBoundingRectangle"": [
                    {
                      ""x"": 26.7,
                      ""y"": 8.5
                    },
                    {
                      ""x"": 79.3,
                      ""y"": 9.5
                    },
                    {
                      ""x"": 78.6,
                      ""y"": 49.4
                    },
                    {
                      ""x"": 26.4,
                      ""y"": 48.4
                    }
                  ],
                  ""strokeIds"": [
                    123,
                    124,
                    125,
                    126
                  ]
                }
              ]
            }";
            return writingJsonWithBullet;
        }

        public static string GetSimpleJsonForDrawing()
        {
            var drawingJson = @"{
            ""recognitionUnits"": [
                {
                    ""boundingRectangle"": {
                    ""height"": 47.6,
                    ""topX"": 52.9,
                    ""topY"": 19.4,
                    ""width"": 51.2
                    },
                    ""category"": ""inkDrawing"",
                    ""center"": {
                    ""x"": 78.2,
                    ""y"": 48.7
                    },
                    ""class"": ""leaf"",
                    ""confidence"": 1.0,
                    ""id"": 1,
                    ""parentId"": 0,
                    ""points"": [
                    {
                        ""x"": 78.1,
                        ""y"": 19.9
                    },
                    {
                        ""x"": 103.8,
                        ""y"": 66.5
                    },
                    {
                        ""x"": 52.8,
                        ""y"": 59.7
                    }
                    ],
                    ""recognizedObject"": ""triangle"",
                    ""rotatedBoundingRectangle"": [
                    {
                        ""x"": 79.5,
                        ""y"": 18.7
                    },
                    {
                        ""x"": 103.5,
                        ""y"": 67.0
                    },
                    {
                        ""x"": 64.3,
                        ""y"": 86.4
                    },
                    {
                        ""x"": 40.4,
                        ""y"": 38.1
                    }
                    ],
                    ""rotationAngle"": 0.0,
                    ""strokeIds"": [
                    95
                    ]
                },
                {
                    ""boundingRectangle"": {
                        ""height"": 120.4,
                        ""topX"": 47.8,
                        ""topY"": 18.2,
                        ""width"": 207.5
                    },
                    ""category"": ""root"",
                    ""childIds"": [1],
                    ""class"": ""container"",
                    ""id"": 0,
                    ""parentId"": 4294967295,
                    ""rotatedBoundingRectangle"": [{
                        ""x"": 47.8,
                        ""y"": 18.2
                    },
                    {
                        ""x"": 254.5,
                        ""y"": 18.25
                    },
                    {
                        ""x"": 254.5,
                        ""y"": 138.6
                    },
                    {
                        ""x"": 47.8,
                        ""y"": 138.6
                    }],
                    ""strokeIds"": [95]
                }
                ]
            }";
            return drawingJson;
        }
    }
}
